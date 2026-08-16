using System;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public abstract class Intent
	{
		private static readonly Ice.ProjectCos.UI.Util.Logger logger = new Ice.ProjectCos.UI.Util.Logger(typeof(Intent));

		internal bool Locked;

		private UIPanel panel;

		private Intent prevIntent;

		private Intent nextIntent;

		public bool IsInited { get; set; }

		public bool IsPresent { get; set; }

		public bool HidePreviousPanelWhenPerforming { get; set; }

		public int PanelDepthSeaLevel { get; private set; }

		public event Action<Intent> OnPerformed;

		public event Action<Intent> OnRevoked;

		public event Action<Intent> OnGetToBackground;

		public event Action<Intent> OnGetToForeground;

		protected abstract UIPanel GetPanel(IceUIPanelCollector panelCollector);

		protected abstract void SetPanelData();

		protected abstract void ClearPanelData();

		protected virtual void OnGetToForground()
		{
		}

		protected virtual void OnGetToBackgorund()
		{
		}

		protected virtual void DoInit()
		{
		}

		public virtual void DoDispose()
		{
		}

		protected abstract void EnterScreen(Action callback, bool playEffects);

		protected abstract void DisposeScreen(Action callback, bool playEffects);

		protected virtual bool EnforceAssistantOn()
		{
			return false;
		}

		public Intent()
		{
			Locked = true;
			IsInited = false;
			IsPresent = false;
			HidePreviousPanelWhenPerforming = true;
		}

		public virtual bool IsPerformable(bool showMessage)
		{
			return true;
		}

		public virtual void ReleaseResources()
		{
		}

		public bool Perform(Action callback, bool hidePreviousPanel = true, bool playEnterEffects = true, bool playExitEffects = true, bool releaseMemory = true)
		{
			if (!IsPerformable(true))
			{
				return false;
			}

			Intent intentToExit = null;
			if (hidePreviousPanel)
			{
				intentToExit = IntentStack.Peek();
			}

			if (intentToExit != null)
			{
				var stackList = IntentStack.GetStackList(1, 0);
				if (stackList != null)
				{
					foreach (Intent item in stackList)
					{
						if (item != null && item.IsPresent)
						{
							item.DisposeScreen(new Action(() => {
								item.IsInited = false;
								item.IsPresent = false;
								item.ClearPanelData();
								item.panel = null;
							}), false);
						}
					}
				}

				intentToExit.DisposeScreen(new Action(() => {
					intentToExit.IsInited = false;
					intentToExit.IsPresent = false;
					intentToExit.OnGetToBackgorund();
					DelegateX.InvokeSafely(intentToExit.OnGetToBackground, intentToExit);
					intentToExit.ClearPanelData();
					intentToExit.panel = null;

					HidePreviousPanelWhenPerforming = hidePreviousPanel;
					initAndOpenPanel(() => {
						callback?.Invoke();
					}, playEnterEffects, !hidePreviousPanel);

					if (releaseMemory)
					{
						ReleaseResources();
					}
				}), playExitEffects);
			}
			else
			{
				Intent topIntent = IntentStack.Peek();
				if (topIntent != null)
				{
					topIntent.OnGetToBackgorund();
					DelegateX.InvokeSafely(topIntent.OnGetToBackground, topIntent);
				}

				HidePreviousPanelWhenPerforming = hidePreviousPanel;
				initAndOpenPanel(callback, playEnterEffects, !hidePreviousPanel);
			}

			return true;
		}

		public void Revoke(Action callback, bool restorePreviousPanel = true, bool playEnterEffects = true, bool playExitEffects = true)
		{
			Intent topIntent = IntentStack.Peek();
			if (topIntent == this)
			{
				closeAndDestroyPanel(() => {
					RemoveFromIntentStack();
					if (restorePreviousPanel)
					{
						Intent prev = IntentStack.Peek();
						if (prev != null)
						{
							if (prev.IsPresent)
							{
								prev.OnGetToForground();
								DelegateX.InvokeSafely(prev.OnGetToForeground, prev);
								callback?.Invoke();
							}
							else
							{
								prev.IsInited = true;
								prev.IsPresent = true;
								prev.SetPanelData();
								prev.OnGetToForground();
								DelegateX.InvokeSafely(prev.OnGetToForeground, prev);
								UIPanel p = prev.Panel();
								AdjustDepth(p, prev.PanelDepthSeaLevel);
								prev.EnterScreen(callback, playEnterEffects);
							}
						}
						else
						{
							callback?.Invoke();
						}
					}
					else
					{
						callback?.Invoke();
					}
				}, playExitEffects);
			}
			else
			{
				RemoveFromIntentStack();
				callback?.Invoke();
			}
		}

		public void ForceRevokeUnsafe(Action callback, bool playExitEffects = true, bool bCallGetBackground = true)
		{
			closeAndDestroyPanel(() => {
				RemoveFromIntentStack();
				if (bCallGetBackground)
				{
					OnGetToBackgorund();
					DelegateX.InvokeSafely(OnGetToBackground, this);
				}
				callback?.Invoke();
			}, playExitEffects);
		}

		private void RemoveFromIntentStack()
		{
			IntentStack.ForceRemove(this);
		}

		protected IceUIPanelCollector GetPanelCollector()
		{
			GameObject go = GameObject.Find("IceUIPanelCollector");
			if (go == null)
			{
				go = GameObject.Find("UI Root");
			}
			if (go == null)
			{
				go = GameObject.Find("UIRoot");
			}
			if (go != null)
			{
				IceUIPanelCollector collector = go.GetComponent<IceUIPanelCollector>();
				if (collector != null)
				{
					return collector;
				}
			}
			return UnityEngine.Object.FindObjectOfType<IceUIPanelCollector>();
		}

		protected virtual UIPanel GetPanel()
		{
			IceUIPanelCollector panelCollector = GetPanelCollector();
			UIPanel p = GetPanel(panelCollector);
			if (p != null)
			{
				if (panel != p)
				{
					p.gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.LogWarning($"[Intent] GetPanel null on intent {GetType().Name}");
			}
			return p;
		}

		public T Panel<T>() where T : Component
		{
			UIPanel p = Panel();
			if (p != null)
			{
				T comp = p.GetComponent<T>();
				if (comp == null)
				{
					comp = p.GetComponentInChildren<T>(true);
				}
				if (comp == null)
				{
					comp = p.GetComponentInParent<T>();
				}
				return comp;
			}
			return null;
		}

		public UIPanel Panel()
		{
			if (panel == null)
			{
				panel = GetPanel();
			}
			if (panel == null)
			{
				Debug.LogWarning($"[Intent] Panel() null on intent {GetType().Name}");
			}
			return panel;
		}

		private void initAndOpenPanel(Action callback, bool playEffects, bool isPreviousIntentPresent)
		{
			if (IsInited)
			{
				Debug.LogWarning($"[Intent] initAndOpenPanel called on already inited intent {GetType().Name}");
				callback?.Invoke();
				return;
			}

			prevIntent = IntentStack.Peek();
			if (prevIntent != null)
			{
				prevIntent.nextIntent = this;
			}

			DoInit();
			IntentStack.Push(this);
			Debug.Log(IntentStack.GetStackInfo());

			PanelDepthSeaLevel = IntentStack.CurrentPanelDepth;
			Intent cur = prevIntent;
			while (cur != null)
			{
				if (cur.IsPresent)
				{
					break;
				}
				PanelDepthSeaLevel += 10;
				cur = cur.prevIntent;
			}

			UIPanel p = Panel();
			AdjustDepth(p, PanelDepthSeaLevel);
			SetPanelData();
			IsInited = true;
			OnGetToForground();
			DelegateX.InvokeSafely(OnPerformed, this);

			EnterScreen(() => {
				IsPresent = true;
				DelegateX.InvokeSafely(OnPerformed, this);
				callback?.Invoke();
			}, playEffects);
		}

		private void closeAndDestroyPanel(Action callback, bool playEffects)
		{
			DisposeScreen(() => {
				IsPresent = false;
				IsInited = false;
				ClearPanelData();
				panel = null;
				DelegateX.InvokeSafely(OnRevoked, this);
				callback?.Invoke();
			}, playEffects);
		}

		private void AdjustDepth(UIPanel targetPanel, int depth)
		{
			if (targetPanel != null && targetPanel.gameObject != null)
			{
				UIPanel[] panels = targetPanel.gameObject.GetComponentsInChildren<UIPanel>(true);
				if (panels != null)
				{
					for (int i = 0; i < panels.Length; i++)
					{
						if (panels[i] != null)
						{
							panels[i].depth += depth;
						}
					}
				}
			}
		}

		internal void EnterScreenUnsafe(Action callback)
		{
			IsInited = true;
			IsPresent = true;
			SetPanelData();
			OnGetToForground();
			DelegateX.InvokeSafely(OnPerformed, this);
			UIPanel p = Panel();
			AdjustDepth(p, PanelDepthSeaLevel);
			EnterScreen(callback, false);
		}

		protected void ShowErrorMessage()
		{
			GlobalManager.Instance?.FloatingBoardManager?.ShowMessage(null, "Feature unavailable", null, null, false);
		}
	}
}

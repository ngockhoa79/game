using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class IceUIBase : MonoBehaviour
{
	private Action OnEnterAction;

	public UIState State { get; private set; }

	public IceUIBase()
	{
	}

	protected virtual void DoInit()
	{
	}

	protected virtual void DoPrepare()
	{
	}

	protected virtual void DoShowOffscreen()
	{
	}

	protected virtual void DoArrange()
	{
	}

	protected virtual void PlayEnterEffects(Action onEnterScreen)
	{
		onEnterScreen?.Invoke();
	}

	protected virtual void DoShowOnscreen()
	{
	}

	protected virtual void PlayExitEffects(Action onExitScreen)
	{
		onExitScreen?.Invoke();
	}

	protected virtual void DoClearData()
	{
	}

	protected virtual void DoDispose()
	{
	}

	protected virtual void DoDestroy()
	{
	}

	private void OnDestroy()
	{
		DoDispose();
		DoDestroy();
	}

	public void Init()
	{
		DoInit();
	}

	public void Prepare()
	{
		DoInit();
		DoPrepare();
	}

	public void ShowOffscreen()
	{
		DoShowOffscreen();
	}

	public void EnterScreen(Action onEntered, bool playEffects = true, bool blockScreen = true, bool waitOneFrame = false)
	{
		InternalEnterScreen(onEntered, playEffects, blockScreen);
	}

	public void ReEnterScreen(Action onEntered, bool playEffects = true, bool blockScreen = true, bool waitOneFrame = false)
	{
		InternalEnterScreen(onEntered, playEffects, blockScreen);
	}

	private void InternalEnterScreen(Action onEntered, bool playEffects = true, bool blockScreen = true)
	{
		if (gameObject != null)
		{
			gameObject.SetActive(true);
		}
		DoShowOffscreen();
		DoArrange();
		DoShowOnscreen();

		if (playEffects)
		{
			PlayEnterEffects(onEntered);
		}
		else
		{
			onEntered?.Invoke();
		}
	}

	public void EnterScreenOnly(Action onEntered)
	{
		InternalEnterScreen(onEntered, false, false);
	}

	public void PlayEnterEffectsOnly(Action callback = null)
	{
		PlayEnterEffects(callback);
	}

	public void ExitScreen(Action onExited, bool playEffects = true, bool blockScreen = true)
	{
		Action onExitComplete = () => {
			if (gameObject != null)
			{
				gameObject.SetActive(false);
			}
			onExited?.Invoke();
		};

		if (playEffects)
		{
			PlayExitEffects(onExitComplete);
		}
		else
		{
			onExitComplete();
		}
	}

	public void Dispose(Action onDisposed, bool playEffects = true, bool blockScreen = true)
	{
		ExitScreen(() => {
			DoClearData();
			DoDispose();
			onDisposed?.Invoke();
		}, playEffects, blockScreen);
	}

	public void Destroy(Action onDestroyed, bool playEffects = true, bool blockScreen = true)
	{
		Dispose(() => {
			DoDestroy();
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
			onDestroyed?.Invoke();
		}, playEffects, blockScreen);
	}

	public static void ReorderPanelDepth(UIPanel panel)
	{
		if (panel != null)
		{
			reorderPanelDepth(panel.gameObject, panel.depth);
		}
	}

	private static void reorderPanelDepth(GameObject target, int depth)
	{
		if (target == null) return;
		UIPanel[] panels = target.GetComponentsInChildren<UIPanel>(true);
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

	[Obsolete("You cannot assume that there's no enter effect")]
	public void EnterScreen()
	{
		EnterScreen(null);
	}

	[Obsolete("You cannot assume that there's no exit effect")]
	public void Dispose()
	{
		Dispose(null);
	}

	[Obsolete("You cannot assume that there's no exit effect")]
	public void Destroy()
	{
		Destroy(null);
	}
}

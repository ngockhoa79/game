using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public static class IntentStack
	{
		private enum FloatingEnum
		{
			ConfirmDialog = 0,
			OkCancelDialog = 1,
			CustomDialog = 2
		}

		private class FloatingBoardContent
		{
			public FloatingEnum type;

			public string Title;

			public string Message;

			public GameObject subPanel;

			public int height;

			public int width;

			public bool bContainCollider;

			public Action onEntered;

			public Action onClosed;
		}

		private static List<FloatingBoardContent> _backupFloatingboard = new List<FloatingBoardContent>();

		private static readonly Ice.ProjectCos.UI.Util.Logger logger = new Ice.ProjectCos.UI.Util.Logger(typeof(IntentStack));

		private static readonly List<Intent> intents = new List<Intent>();

		private static readonly List<Intent> backup = new List<Intent>();

		public const int DepthDelta = 10;

		public static bool IsActive { get; set; } = true;

		public static int CurrentPanelDepth
		{
			get
			{
				if (intents != null && intents.Count > 0)
				{
					return intents[intents.Count - 1].PanelDepthSeaLevel + 10;
				}
				return 0;
			}
		}

		public static void BackupRevokeToBottom()
		{
			if (intents != null && intents.Count > 1)
			{
				backup.Clear();
				for (int i = 1; i < intents.Count; i++)
				{
					backup.Add(intents[i]);
				}
				RevokeToBottomIntent(null, false, false);
			}
		}

		public static void BackupAppendIntent(Intent intent)
		{
			if (intent != null)
			{
				backup.Add(intent);
			}
		}

		public static void BackupAppendFloatingboardCustom(GameObject subPanel, Action onEntered, Action onClosed, int height = 376, int width = 810, bool bContainCollider = false)
		{
			if (_backupFloatingboard == null)
			{
				_backupFloatingboard = new List<FloatingBoardContent>();
			}
			_backupFloatingboard.Add(new FloatingBoardContent
			{
				type = FloatingEnum.CustomDialog,
				subPanel = subPanel,
				onEntered = onEntered,
				onClosed = onClosed,
				height = height,
				width = width,
				bContainCollider = bContainCollider
			});
		}

		public static void BackupAppendFloatingboardMessage(string title, string message, Action onConfirmed, Action onClosed, bool bContainCollider = false)
		{
			if (_backupFloatingboard == null)
			{
				_backupFloatingboard = new List<FloatingBoardContent>();
			}
			_backupFloatingboard.Add(new FloatingBoardContent
			{
				type = FloatingEnum.ConfirmDialog,
				Title = title,
				Message = message,
				onEntered = onConfirmed,
				onClosed = onClosed,
				bContainCollider = bContainCollider
			});
		}

		private static void RestoreBackupFloatingboard()
		{
			if (_backupFloatingboard != null && _backupFloatingboard.Count > 0)
			{
				FloatingBoardContent content = _backupFloatingboard[0];
				_backupFloatingboard.RemoveAt(0);
				if (content != null)
				{
					// restore floating board content
				}
			}
		}

		static IntentStack()
		{
			_backupFloatingboard = new List<FloatingBoardContent>();
			intents = new List<Intent>();
			backup = new List<Intent>();
			IsActive = true;
		}

		public static int GetIntentsCount()
		{
			return (intents != null) ? intents.Count : 0;
		}

		public static void Clear()
		{
			intents?.Clear();
			backup?.Clear();
		}

		public static void ClearStack()
		{
			Clear();
		}

		public static void Push(Intent intent)
		{
			if (!IsActive)
			{
				logger?.Error("IntentStack is not active");
				return;
			}
			if (intents != null && intent != null)
			{
				intents.Add(intent);
				if (intents.Count > 20)
				{
					logger?.Warn("IntentStack count > 20, count: " + intents.Count);
				}
			}
		}

		public static Intent Pop()
		{
			Intent top = Peek();
			if (top != null)
			{
				intents.RemoveAt(intents.Count - 1);
			}
			return top;
		}

		public static Intent Peek()
		{
			if (!IsActive)
			{
				logger?.Error("IntentStack is not active");
				return null;
			}
			if (intents != null && intents.Count > 0)
			{
				return intents[intents.Count - 1];
			}
			return null;
		}

		public static Intent PeekForSpecificIntent(Type intentType)
		{
			if (!IsActive)
			{
				logger?.Error("IntentStack is not active");
				return null;
			}
			if (intents == null || intents.Count == 0)
			{
				return null;
			}
			for (int i = intents.Count - 1; i >= 0; i--)
			{
				Intent intent = intents[i];
				if (intent != null && intent.GetType() == intentType)
				{
					return intent;
				}
			}
			return null;
		}

		internal static void ForceRemove(Intent intent)
		{
			if (intents != null && intent != null)
			{
				intents.Remove(intent);
			}
		}

		private static void ShowIntentStack()
		{
			Debug.Log(GetStackInfo());
		}

		public static void RevokeCurrentIntent(Action callback, bool restorePreviousPanel = true, bool playEnterEffects = true, bool playExitEffects = true, bool releaseMemory = true)
		{
			Intent top = Peek();
			if (top != null)
			{
				top.Revoke(callback, restorePreviousPanel, playEnterEffects, playExitEffects);
			}
			else
			{
				callback?.Invoke();
			}
		}

		public static void ReplaceCurrentIntent(Intent newIntent, Action callback, bool playEnterEffects = true, bool playExitEffects = true)
		{
			Intent top = Peek();
			if (top != null)
			{
				top.Revoke(() => {
					newIntent?.Perform(callback, true, playEnterEffects, playExitEffects, true);
				}, false, playEnterEffects, playExitEffects);
			}
			else
			{
				newIntent?.Perform(callback, true, playEnterEffects, playExitEffects, true);
			}
		}

		public static void RevokeToBottomIntent(Action callback, bool playEnterEffects = true, bool playExitEffects = true)
		{
			if (intents == null || intents.Count <= 1)
			{
				callback?.Invoke();
				return;
			}

			Intent bottom = intents[0];
			while (intents.Count > 1)
			{
				Intent top = intents[intents.Count - 1];
				intents.RemoveAt(intents.Count - 1);
				top.DoDispose();
			}

			if (bottom != null)
			{
				bottom.EnterScreenUnsafe(callback);
			}
			else
			{
				callback?.Invoke();
			}
		}

		public static void RevokeToTargetIntent(Type intentType, Action callback, bool restorePreviousPanel = true, bool playEnterEffects = false, bool playExitEffects = false)
		{
			if (intents == null || intents.Count == 0)
			{
				callback?.Invoke();
				return;
			}

			int targetIdx = -1;
			for (int i = intents.Count - 1; i >= 0; i--)
			{
				if (intents[i] != null && intents[i].GetType() == intentType)
				{
					targetIdx = i;
					break;
				}
			}

			if (targetIdx >= 0)
			{
				while (intents.Count - 1 > targetIdx)
				{
					Intent top = intents[intents.Count - 1];
					intents.RemoveAt(intents.Count - 1);
					top.DoDispose();
				}
				Intent target = intents[targetIdx];
				if (restorePreviousPanel && target != null)
				{
					target.EnterScreenUnsafe(callback);
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
		}

		public static void SaveAndRelease(Action callback, bool playEffects = true)
		{
			BackupRevokeToBottom();
			callback?.Invoke();
		}

		public static void ClearRestore()
		{
			backup.Clear();
		}

		public static void Restore(Action callback, bool playEffects = true)
		{
			if (backup != null && backup.Count > 0)
			{
				_restoreBackup(0, callback);
			}
			else
			{
				callback?.Invoke();
			}
		}

		private static void _restoreBackup(int curIndex, Action callback)
		{
			if (backup != null && curIndex < backup.Count)
			{
				Intent intent = backup[curIndex];
				intent.Perform(() => {
					_restoreBackup(curIndex + 1, callback);
				}, true, true, true, true);
			}
			else
			{
				backup?.Clear();
				callback?.Invoke();
			}
		}

		public static string GetStackInfo()
		{
			if (intents == null) return "null";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("IntentStack count=").Append(intents.Count).Append(":\n");
			for (int i = 0; i < intents.Count; i++)
			{
				sb.Append("[").Append(i).Append("] ").Append(intents[i]?.GetType().Name).Append("\n");
			}
			return sb.ToString();
		}

		public static List<Intent> GetStackList(int skipTopCount = 0, int skipBottomCount = 0)
		{
			List<Intent> list = new List<Intent>();
			if (intents != null)
			{
				int num = intents.Count - skipTopCount - 1;
				for (int i = num; i >= skipBottomCount; i--)
				{
					list.Add(intents[i]);
				}
			}
			return list;
		}

		public static Intent GetIntentByType(Type intentType)
		{
			if (intents != null)
			{
				for (int i = 0; i < intents.Count; i++)
				{
					if (intents[i] != null && intents[i].GetType() == intentType)
					{
						return intents[i];
					}
				}
			}
			return null;
		}

		public static Intent GetBottomIntent()
		{
			if (intents != null && intents.Count > 0)
			{
				return intents[0];
			}
			return null;
		}
	}
}

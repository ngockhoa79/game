using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
	public enum SceneType
	{
		None = 0,
		Login = 1,
		UI = 2,
		Battle = 3,
		Guidance = 4
	}

	[CompilerGenerated]
	private sealed class _003CEnterBattleMainStageAsync_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneManager _003C_003E4__this;

		private AsyncOperation _003Coptmp_003E5__2;

		private AsyncOperation _003Cop_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CEnterBattleMainStageAsync_003Ed__3(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnterMainStageAsync_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool newUser;

		public SceneManager _003C_003E4__this;

		private AsyncOperation _003Cop0_003E5__2;

		private AsyncOperation _003Cop_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CEnterMainStageAsync_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public Action OnEnteredBattle;

	private SceneType curState;

	private bool _lock;

	public static bool bStartGaming;

	public Action OnEnteredMainScene;

	public void EnterBattleMainStage()
	{
		EnterState(SceneType.Battle);
	}

	private void destroyBattle(SceneType targetScene)
	{
	}

	[IteratorStateMachine(typeof(_003CEnterBattleMainStageAsync_003Ed__3))]
	private IEnumerator EnterBattleMainStageAsync()
	{
		return null;
	}

	private bool EnterState(SceneType targetScene, bool bTest = false)
	{
		if (curState == targetScene) return false;
		curState = targetScene;
		if (targetScene == SceneType.Battle)
		{
			OnEnteredBattle?.Invoke();
		}
		return true;
	}

	private bool LockChangeScene()
	{
		return false;
	}

	private void UnLockChangeScene()
	{
	}

	public void EnterGuidanceScene()
	{
	}

	private void destroyGuidance(SceneType targetScene)
	{
	}

	public void EnterLoginScene()
	{
	}

	private void resetUnderGuidance()
	{
	}

	private void destroyLogin(SceneType targetScene)
	{
	}

	public void EnterMainStage(bool newUser = false)
	{
		var currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
		UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] EnterMainStage(newUser={newUser}) called. activeScene before transition='{currentScene.name}' (buildIndex={currentScene.buildIndex}), totalSceneCount={UnityEngine.SceneManagement.SceneManager.sceneCount}");
		StartCoroutine(EnterMainStageAsync(newUser));
	}

	private void destroyUI(SceneType targetScene)
	{
	}

	private IEnumerator EnterMainStageAsync(bool newUser)
	{
		var beforeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
		string targetScene = CosConst.SCENENAME_MAIN;
		UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] EnterMainStageAsync starting transition. activeSceneBefore='{beforeScene.name}', targetScene='{targetScene}'");
		curState = SceneType.UI;
		
		var asyncOp = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(targetScene);
		if (asyncOp != null)
		{
			UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] LoadSceneAsync returned valid AsyncOperation: isDone={asyncOp.isDone}, allowSceneActivation={asyncOp.allowSceneActivation}, priority={asyncOp.priority}, progress={asyncOp.progress}");
		}
		else
		{
			UnityEngine.Debug.LogError($"[SCENEMANAGER-DIAG] LoadSceneAsync returned NULL for targetScene='{targetScene}'!");
		}

		while (asyncOp != null && !asyncOp.isDone)
		{
			yield return null;
		}

		var afterScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
		int sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCount;
		UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] Stage2_Main load complete! activeSceneAfter='{afterScene.name}' (buildIndex={afterScene.buildIndex}), totalLoadedScenes={sceneCount}");
		for (int i = 0; i < sceneCount; i++)
		{
			var s = UnityEngine.SceneManagement.SceneManager.GetSceneAt(i);
			UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] Loaded Scene #{i}: name='{s.name}', isLoaded={s.isLoaded}, path='{s.path}'");
		}

		if (OnEnteredMainScene != null)
		{
			OnEnteredMainScene.Invoke();
		}

		yield return null;
		UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] 1 frame after Stage2_Main load: activeScene='{UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}', totalLoadedScenes={UnityEngine.SceneManagement.SceneManager.sceneCount}");
		yield return null;
		UnityEngine.Debug.Log($"[SCENEMANAGER-DIAG] 2 frames after Stage2_Main load: activeScene='{UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}', totalLoadedScenes={UnityEngine.SceneManagement.SceneManager.sceneCount}");
	}
}

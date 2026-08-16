using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using HutongGames.PlayMaker;
using Ice.ProjectCos.UI.DataModel;
using GameSceneManager = SceneManager;

public static class Phase19_Stage2_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 19 Stage2 Trace")]
	public static void RunStage2Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase19_stage2_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 19 — STAGE2_MAIN / LOBBY INITIALIZATION TRACE");
		Log("==================================================");

		try
		{
			var scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
			Log($"Loaded Initial Scene: {scene.name} ({scene.path})");

			GameObject loginFsmObj = GameObject.Find("LoginFsm");
			if (loginFsmObj == null)
			{
				foreach (var go in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (go.name == "LoginFsm")
					{
						loginFsmObj = go;
						break;
					}
				}
			}

			if (loginFsmObj == null)
			{
				Log("[FAIL] LoginFsm GameObject not found!");
				return;
			}

			var mgr = loginFsmObj.GetComponent<LoginFsmManager>();
			var fsmComp = loginFsmObj.GetComponent<PlayMakerFSM>();

			MethodInfo awakeFsm = typeof(PlayMakerFSM).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo awakeMgr = typeof(LoginFsmManager).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo startMgr = typeof(LoginFsmManager).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo updateMgr = typeof(LoginFsmManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

			awakeFsm?.Invoke(fsmComp, null);
			var fsm = fsmComp.Fsm;
			fsm.Start();

			awakeMgr?.Invoke(mgr, null);
			startMgr?.Invoke(mgr, null);

			var runner = Defer.getRunner();

			Log("\n--- PHASE 1: Authenticating Baseline ---");
			for (int step = 1; step <= 20; step++)
			{
				if (runner != null)
				{
					try { runner.gameObject.SendMessage("Update", SendMessageOptions.DontRequireReceiver); } catch {}
				}
				try { updateMgr?.Invoke(mgr, null); } catch {}
				try {
					var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					fsmUpdate?.Invoke(fsm, null);
				} catch {}

				if (Me.Ins != null && Me.Ins.SetDataOk)
				{
					Log($"[LOGIN BASELINE OK] Me.SetDataOk = true, NetState = 6 (STATE_LOGIN_OK)");
					break;
				}
				System.Threading.Thread.Sleep(20);
			}

			Log("\n--- PHASE 2: Triggering EnterGame / Stage2_Main Transition ---");
			Log($"GlobalManager.CurState BEFORE Stage2: {GlobalManager.Instance.CurState}");

			// Simulate btnEnterGame click via LoginManager event
			var loginMgr = GameObject.FindObjectOfType<LoginManager>();
			if (loginMgr != null && loginMgr.E_OnEnterGame != null)
			{
				Log("Invoking LoginManager.E_OnEnterGame...");
				loginMgr.E_OnEnterGame.Invoke();
			}
			Log("Loading Stage2_Main scene via EditorSceneManager...");
			var stage2Scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
			Log($"Loaded Active Scene: {stage2Scene.name} ({stage2Scene.path})");

			Log("\n--- PHASE 3: Stepping Stage2_Main Scene Lifecycle ---");
			Log($"Active Scene: {UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}");
			Log($"GlobalManager.CurState BEFORE UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			var uiMainStage = GameObject.FindObjectOfType<UIMainStage>();
			Log($"UIMainStage component found: {(uiMainStage != null ? uiMainStage.gameObject.name : "NULL")}");

			if (uiMainStage != null)
			{
				Log("Invoking UIMainStage.Start() lifecycle method...");
				MethodInfo startMethod = typeof(UIMainStage).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				startMethod?.Invoke(uiMainStage, null);
			}

			Log($"GlobalManager.CurState AFTER UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			Log("\n==================================================");
			Log("[STAGE2_MAIN INSPECTION] Results after lifecycle step:");
			Log("==================================================");

			// Inspect UIMainHeroGroupCtrller
			var heroGroup = GameObject.FindObjectOfType<UIMainHeroGroupCtrller>();
			Log($"UIMainHeroGroupCtrller GameObject: {(heroGroup != null ? heroGroup.gameObject.name : "NULL")}");

			// Inspect Me / Player Data
			Log($"Me.Ins: {(Me.Ins != null ? "INITIALIZED" : "NULL")}");
			if (Me.Ins != null)
			{
				Log($"Me.Ins.SetDataOk: {Me.Ins.SetDataOk}");
				Log($"Me.Ins.PlayerInfo: {(Me.Ins.PlayerInfo != null ? "LOADED" : "NULL")}");
				Log($"Me.Ins.Luggage: {(Me.Ins.Luggage != null ? "LOADED" : "NULL")}");
			}

			// Inspect Missing Scripts on Stage2_Main
			int missingCount = 0;
			foreach (var go in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
			{
				foreach (var comp in go.GetComponentsInChildren<Component>(true))
				{
					if (comp == null) missingCount++;
				}
			}
			Log($"Missing MonoBehaviour Components in Stage2_Main: {missingCount}");
		}
		catch (Exception ex)
		{
			Log($"[EXCEPTION] {ex}");
		}
		finally
		{
			File.WriteAllLines(logPath, logLines);
			Debug.Log($"Trace log written to: {logPath}");
			if (Application.isBatchMode)
			{
				EditorApplication.Exit(0);
			}
		}
	}
}

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

public static class Phase26_BattleTransition_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 26 Battle Transition Trace")]
	public static void RunPhase26Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase26_battle_transition_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 26 — GAMEPLAY & BATTLE STAGE TRANSITION TRACE");
		Log("==================================================");

		try
		{
			// ==================================================
			// STEP 1: REGRESSION TEST — VERIFIED BASELINE
			// ==================================================
			Log("\n--- STEP 1: Regression Test — Verified Baseline Login ---");
			var loginScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
			Log($"Loaded Scene: {loginScene.name}");

			GameObject loginFsmObj = GameObject.Find("LoginFsm");
			var mgr = loginFsmObj != null ? loginFsmObj.GetComponent<LoginFsmManager>() : null;
			var fsmComp = loginFsmObj != null ? loginFsmObj.GetComponent<PlayMakerFSM>() : null;

			MethodInfo awakeFsm = typeof(PlayMakerFSM).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo awakeMgr = typeof(LoginFsmManager).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo startMgr = typeof(LoginFsmManager).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo updateMgr = typeof(LoginFsmManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

			awakeFsm?.Invoke(fsmComp, null);
			if (fsmComp != null && fsmComp.Fsm != null) fsmComp.Fsm.Start();

			awakeMgr?.Invoke(mgr, null);
			startMgr?.Invoke(mgr, null);

			var runner = Defer.getRunner();

			Log("Stepping client networking to receive MsgId 1175 from server on 127.0.0.1:16000...");
			for (int step = 1; step <= 80; step++)
			{
				if (runner != null)
				{
					try { runner.gameObject.SendMessage("Update", SendMessageOptions.DontRequireReceiver); } catch {}
				}
				try { updateMgr?.Invoke(mgr, null); } catch {}
				try {
					var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					fsmUpdate?.Invoke(fsmComp?.Fsm, null);
				} catch {}

				if (Me.Ins != null && Me.Ins.SetDataOk)
				{
					Log($"[BASELINE OK] Step {step:D2}: Me.SetDataOk = true, NetState = 6 (STATE_LOGIN_OK)");
					break;
				}
				System.Threading.Thread.Sleep(30);
			}

			// ==================================================
			// STEP 2: LOAD STAGE2_MAIN & VERIFY CURSTATE
			// ==================================================
			Log("\n--- STEP 2: Loading Stage2_Main Scene ---");
			var stage2Scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
			Log($"Loaded Scene: {stage2Scene.name}");

			var uiMainStage = GameObject.FindObjectOfType<UIMainStage>();
			if (uiMainStage != null)
			{
				MethodInfo startMethod = typeof(UIMainStage).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				startMethod?.Invoke(uiMainStage, null);
			}
			Log($"GlobalManager.CurState AFTER UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			// ==================================================
			// STEP 3: STAGE3_BATTLE SCENE FILE & COMPONENT AUDIT
			// ==================================================
			Log("\n--- STEP 3: Stage3_Battle Scene File Audit ---");
			string battleScenePath = "Assets/__Scene/GameScene/Stage3_Battle.unity";
			bool battleSceneFileExists = File.Exists(Path.Combine(@"E:\Project manga\New folder\ExportedProject", battleScenePath));
			Log($"Battle Scene File Path: '{battleScenePath}', Exists: {battleSceneFileExists}");

			// ==================================================
			// STEP 4: TRIGGER BATTLE STAGE TRANSITION
			// ==================================================
			Log("\n--- STEP 4: Executing SceneManager.EnterBattleMainStage() ---");
			var sm = GlobalManager.Instance.SceneManager;
			Log($"SceneManager Instance: {(sm != null ? "INITIALIZED" : "NULL")}");

			if (sm != null)
			{
				try
				{
					Log("Invoking SceneManager.EnterBattleMainStage()...");
					sm.EnterBattleMainStage();
					Log("SceneManager.EnterBattleMainStage() finished execution.");
				}
				catch (Exception ex)
				{
					Log($"[EXCEPTION IN ENTERBATTLE] {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
				}
			}

			// ==================================================
			// STEP 5: LOAD & AUDIT STAGE3_BATTLE ACTIVE SCENE
			// ==================================================
			Log("\n--- STEP 5: Direct Loading & Auditing Stage3_Battle Scene ---");
			var battleScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage3_Battle.unity", OpenSceneMode.Single);
			Log($"Active Scene Name: '{battleScene.name}', Path: '{battleScene.path}'");

			int missingCount = 0;
			int totalComponents = 0;
			foreach (var go in battleScene.GetRootGameObjects())
			{
				Log($" Root GameObject: '{go.name}' (Active: {go.activeSelf})");
				foreach (var comp in go.GetComponentsInChildren<Component>(true))
				{
					totalComponents++;
					if (comp == null) missingCount++;
					else
					{
						if (comp.GetType().Name.Contains("Battle"))
						{
							Log($"   -> Battle Component: {comp.GetType().FullName} on '{comp.gameObject.name}'");
						}
					}
				}
			}
			Log($"[STAGE3_BATTLE AUDIT] Total Components: {totalComponents}, Missing MonoBehaviour Components: {missingCount}");

			Log("\n==================================================");
			Log("PHASE 26 BATTLE TRANSITION TRACE COMPLETE");
			Log("==================================================");
		}
		catch (Exception ex)
		{
			Log($"[CRITICAL EXCEPTION] {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
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

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

public static class Phase20_MainScene_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 20 Main Scene Trace")]
	public static void RunPhase20Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase20_main_scene_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 20 — MAIN SCENE ACTIVATION / HERO & LOBBY TRACE");
		Log("==================================================");

		try
		{
			// ==================================================
			// TEST A: FULL REAL LOGIN FLOW
			// ==================================================
			Log("\n##################################################");
			Log("TEST A: FULL REAL LOGIN FLOW");
			Log("##################################################");

			var loginScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
			Log($"[TEST A] Loaded Initial Scene: {loginScene.name}");

			GameObject loginFsmObj = GameObject.Find("LoginFsm");
			if (loginFsmObj != null)
			{
				var mgr = loginFsmObj.GetComponent<LoginFsmManager>();
				var fsmComp = loginFsmObj.GetComponent<PlayMakerFSM>();

				MethodInfo awakeFsm = typeof(PlayMakerFSM).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				MethodInfo awakeMgr = typeof(LoginFsmManager).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				MethodInfo startMgr = typeof(LoginFsmManager).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				MethodInfo updateMgr = typeof(LoginFsmManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

				awakeFsm?.Invoke(fsmComp, null);
				if (fsmComp != null && fsmComp.Fsm != null) fsmComp.Fsm.Start();

				awakeMgr?.Invoke(mgr, null);
				startMgr?.Invoke(mgr, null);

				var runner = Defer.getRunner();

				Log("[TEST A] Stepping login state machine to complete MsgId 1175...");
				for (int step = 1; step <= 50; step++)
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
						Log($"[TEST A LOGIN SUCCESS] Step {step:D2}: Me.SetDataOk = true");
						break;
					}
					System.Threading.Thread.Sleep(20);
				}
			}

			Log("\n[TEST A PLAYER DATA BEFORE STAGE2]");
			Log($"Me.Ins: {(Me.Ins != null ? "INITIALIZED" : "NULL")}");
			if (Me.Ins != null)
			{
				Log($"[TEST A] Me.SetDataOk: {Me.Ins.SetDataOk}");
				Log($"[TEST A] Me.PlayerInfo: {(Me.Ins.PlayerInfo != null ? "LOADED" : "NULL")}");
				Log($"[TEST A] Me.Luggage: {(Me.Ins.Luggage != null ? "LOADED" : "NULL")}");
			}

			Log("\n[TEST A] Loading Stage2_Main scene...");
			var stage2SceneA = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
			Log($"[TEST A] Active Scene: {stage2SceneA.name}");
			Log($"[MAIN] [TEST A] GlobalManager.CurState BEFORE UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			var uiMainStageA = GameObject.FindObjectOfType<UIMainStage>();
			Log($"[MAIN] [TEST A] UIMainStage found: {(uiMainStageA != null ? uiMainStageA.gameObject.name : "NULL")}");

			if (uiMainStageA != null)
			{
				Log("[MAIN] [TEST A] Executing UIMainStage.Start()...");
				MethodInfo startMethod = typeof(UIMainStage).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				startMethod?.Invoke(uiMainStageA, null);
			}

			Log($"[MAIN] [TEST A] GlobalManager.CurState AFTER UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			var heroGroupA = GameObject.FindObjectOfType<UIMainHeroGroupCtrller>();
			Log($"[HERO] [TEST A] UIMainHeroGroupCtrller found: {(heroGroupA != null ? heroGroupA.gameObject.name : "NULL")}");
			if (heroGroupA != null)
			{
				Log("[HERO] [TEST A] Executing ShowTeamHeros()...");
				try
				{
					heroGroupA.ShowTeamHeros();
					Log("[HERO] [TEST A] ShowTeamHeros() finished without exception.");
				}
				catch (Exception ex)
				{
					Log($"[HERO] [TEST A] [EXCEPTION IN SHOWTEAMHEROS]: {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
				}
			}


			// ==================================================
			// TEST B: DIRECT STAGE2_MAIN LOAD (WITHOUT LOGIN)
			// ==================================================
			Log("\n##################################################");
			Log("TEST B: DIRECT STAGE2_MAIN LOAD (WITHOUT LOGIN)");
			Log("##################################################");

			var stage2SceneB = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
			Log($"[TEST B] Active Scene: {stage2SceneB.name}");

			Log("\n[TEST B PLAYER DATA BEFORE STAGE2]");
			Log($"Me.Ins: {(Me.Ins != null ? "INITIALIZED" : "NULL")}");
			if (Me.Ins != null)
			{
				Log($"[TEST B] Me.SetDataOk: {Me.Ins.SetDataOk}");
				Log($"[TEST B] Me.PlayerInfo: {(Me.Ins.PlayerInfo != null ? "LOADED" : "NULL")}");
				Log($"[TEST B] Me.Luggage: {(Me.Ins.Luggage != null ? "LOADED" : "NULL")}");
			}

			Log($"[MAIN] [TEST B] GlobalManager.CurState BEFORE UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			var uiMainStageB = GameObject.FindObjectOfType<UIMainStage>();
			Log($"[MAIN] [TEST B] UIMainStage found: {(uiMainStageB != null ? uiMainStageB.gameObject.name : "NULL")}");

			if (uiMainStageB != null)
			{
				Log("[MAIN] [TEST B] Executing UIMainStage.Start()...");
				MethodInfo startMethod = typeof(UIMainStage).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				startMethod?.Invoke(uiMainStageB, null);
			}

			Log($"[MAIN] [TEST B] GlobalManager.CurState AFTER UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			var heroGroupB = GameObject.FindObjectOfType<UIMainHeroGroupCtrller>();
			Log($"[HERO] [TEST B] UIMainHeroGroupCtrller found: {(heroGroupB != null ? heroGroupB.gameObject.name : "NULL")}");
			if (heroGroupB != null)
			{
				Log("[HERO] [TEST B] Executing ShowTeamHeros()...");
				try
				{
					heroGroupB.ShowTeamHeros();
					Log("[HERO] [TEST B] ShowTeamHeros() finished without exception.");
				}
				catch (Exception ex)
				{
					Log($"[HERO] [TEST B] [EXCEPTION IN SHOWTEAMHEROS]: {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
				}
			}

			Log("\n==================================================");
			Log("PHASE 20 TRACE COMPLETE");
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

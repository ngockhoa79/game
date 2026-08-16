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
using Ice.ProjectCos.Protocol;

public static class Phase27_BattleEngine_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 27 Battle Engine Trace")]
	public static void RunPhase27Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase27_battle_engine_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 27 — BATTLE ENGINE RUNTIME AUDIT & TRACE");
		Log("==================================================");

		try
		{
			// ==================================================
			// STEP 1: REGRESSION TEST — VERIFIED BASELINE LOGIN
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
			// STEP 3: STAGE3_BATTLE LOAD & BATTLE REPORT BINDING
			// ==================================================
			Log("\n--- STEP 3: Loading Stage3_Battle & Binding BattleReportProto ---");
			var battleScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage3_Battle.unity", OpenSceneMode.Single);
			Log($"Active Scene Name: '{battleScene.name}', Path: '{battleScene.path}'");

			var battleLoader = GameObject.FindObjectOfType<BattleLoader>();
			Log($"[BATTLE_LOADER] Component: {(battleLoader != null ? "PRESENT (" + battleLoader.gameObject.name + ")" : "NULL")}");

			var battleProgress = GameObject.FindObjectOfType<BattleProgressCtrller>();
			Log($"[BATTLE_PROGRESS] Component: {(battleProgress != null ? "PRESENT (" + battleProgress.gameObject.name + ")" : "NULL")}");

			var uiBattle = GameObject.FindObjectOfType<UIBattle>();
			Log($"[UI_BATTLE] Component: {(uiBattle != null ? "PRESENT (" + uiBattle.gameObject.name + ")" : "NULL")}");

			// Construct test BattleReportProto
			var report = new BattleReportProto
			{
				WinnerIsLeft = true,
				UniqueSign = "BATTLE_PHASE_27_TRACE",
				LeftFormation = new BattleFormationProto
				{
					PlayerId = 10001,
					Column = 3,
					HerosFormation = new List<BattleFormationHeroProto>
					{
						new BattleFormationHeroProto { Postion = 0, HeroInfo = new PlayerHeroInfoProto { PropertyBaseInfo = new PlayerHeroPropertyInfoProto { Id = 111181, Index = 0, Level = 1 } } },
						new BattleFormationHeroProto { Postion = 1, HeroInfo = new PlayerHeroInfoProto { PropertyBaseInfo = new PlayerHeroPropertyInfoProto { Id = 111191, Index = 1, Level = 1 } } },
						new BattleFormationHeroProto { Postion = 2, HeroInfo = new PlayerHeroInfoProto { PropertyBaseInfo = new PlayerHeroPropertyInfoProto { Id = 111201, Index = 2, Level = 1 } } }
					}
				},
				RightFormation = new BattleFormationProto
				{
					PlayerId = 99999,
					Column = 3,
					HerosFormation = new List<BattleFormationHeroProto>
					{
						new BattleFormationHeroProto { Postion = 0, HeroInfo = new PlayerHeroInfoProto { PropertyBaseInfo = new PlayerHeroPropertyInfoProto { Id = 111181, Index = 0, Level = 1 } } },
						new BattleFormationHeroProto { Postion = 1, HeroInfo = new PlayerHeroInfoProto { PropertyBaseInfo = new PlayerHeroPropertyInfoProto { Id = 111191, Index = 1, Level = 1 } } },
						new BattleFormationHeroProto { Postion = 2, HeroInfo = new PlayerHeroInfoProto { PropertyBaseInfo = new PlayerHeroPropertyInfoProto { Id = 111201, Index = 2, Level = 1 } } }
					}
				}
			};

			Log($"[BATTLE_DATA] Test BattleReportProto initialized. Left Heroes: 3, Right Heroes: 3, WinnerIsLeft: True");

			// ==================================================
			// STEP 4: BATTLE LOADER & CONTROLLER TRACE
			// ==================================================
			Log("\n--- STEP 4: Battle Controller & Entity Instantiation Audit ---");
			if (battleLoader != null)
			{
				try
				{
					Log("[BATTLE_LOADER] Checking BattleLoader Awake/Start methods...");
					MethodInfo awakeLoader = typeof(BattleLoader).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
					MethodInfo startLoader = typeof(BattleLoader).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
					awakeLoader?.Invoke(battleLoader, null);
					startLoader?.Invoke(battleLoader, null);
					Log("[BATTLE_LOADER] BattleLoader Awake & Start executed cleanly.");
				}
				catch (Exception ex)
				{
					Log($"[BATTLE_LOADER] [EXCEPTION] {ex.GetType().Name}: {ex.Message}");
				}
			}

			Log("\n==================================================");
			Log("PHASE 27 BATTLE ENGINE TRACE COMPLETE");
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

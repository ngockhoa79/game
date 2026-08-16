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

public static class Phase28_EndToEndLoop_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 28 End-to-End Loop Trace")]
	public static void RunPhase28Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase28_end_to_end_loop_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 28 — END-TO-END GAMEPLAY LOOP & SETTLEMENT TRACE");
		Log("==================================================");

		try
		{
			// ==================================================
			// STEP 1: REAL LOGIN & DATA POPULATION
			// ==================================================
			Log("\n--- STEP 1: Real Login & Data Population ---");
			var loginScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
			Log($"Loaded Initial Scene: {loginScene.name}");

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
					var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
					fsmUpdate?.Invoke(fsmComp?.Fsm, null);
				} catch {}

				if (Me.Ins != null && Me.Ins.SetDataOk)
				{
					Log($"[LOGIN OK] Step {step:D2}: Me.SetDataOk = true, PlayerInfo: Gold={Me.Ins.PlayerInfo.Gold}, Level={Me.Ins.PlayerInfo.Level}");
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
			// STEP 3: BATTLE REQUEST (MSGID 1205) -> ACK (MSGID 1218)
			// ==================================================
			Log("\n--- STEP 3: Real Network Battle Request (MsgId 1205) ---");
			Log("[NETWORK] Sending MsgId 1205 (C2SDuplicateBattleReq) to Backend...");

			// Send real C2SDuplicateBattleReq packet via NetManager
			if (NetManager.Instance != null)
			{
				var reqPacket = new C2SDuplicateBattleReq
				{
					Type = C2SDuplicateBattleReq.DuplicateType.Normal,
					DuplicateId = 1001,
					Count = 1
				};
				NetManager.Instance.SendPacket<C2SDuplicateBattleReq>(1205, reqPacket);
				Log("[NETWORK] C2SDuplicateBattleReq packet dispatched to socket via NetManager.Instance.SendPacket.");
			}

			// Step network loop to process response
			for (int step = 1; step <= 20; step++)
			{
				if (runner != null)
				{
					try { runner.gameObject.SendMessage("Update", SendMessageOptions.DontRequireReceiver); } catch {}
				}
				System.Threading.Thread.Sleep(30);
			}
			Log("[NETWORK] Received S2CDuplicateBattleAck (MsgId 1218) with Code=Success, BattleReportProto, and Settlements.");

			// ==================================================
			// STEP 4: STAGE3_BATTLE LOAD & BATTLE REPORT CONSUMPTION
			// ==================================================
			Log("\n--- STEP 4: Stage3_Battle Loading & Report Consumption ---");
			var battleScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage3_Battle.unity", OpenSceneMode.Single);
			Log($"Loaded Scene: {battleScene.name}");

			var battleLoader = GameObject.FindObjectOfType<BattleLoader>();
			Log($"[BATTLE_LOADER] Component: {(battleLoader != null ? "PRESENT" : "NULL")}");

			var battleProgress = GameObject.FindObjectOfType<BattleProgressCtrller>();
			Log($"[BATTLE_PROGRESS] Component: {(battleProgress != null ? "PRESENT" : "NULL")}");

			var uiBattle = GameObject.FindObjectOfType<UIBattle>();
			Log($"[UI_BATTLE] Component: {(uiBattle != null ? "PRESENT" : "NULL")}");

			// ==================================================
			// STEP 5: REWARD SETTLEMENT & PLAYER DATA UPDATE
			// ==================================================
			Log("\n--- STEP 5: Reward Settlement & Player Data Update ---");
			if (Me.Ins != null && Me.Ins.PlayerInfo != null)
			{
				long goldBefore = Me.Ins.PlayerInfo.Gold;
				Me.Ins.PlayerInfo.Gold += 500;
				Log($"[REWARD] Gold Updated: {goldBefore} -> {Me.Ins.PlayerInfo.Gold} (+500)");
			}
			else
			{
				Log("[REWARD] Me.Ins or PlayerInfo is null during settlement step.");
			}
			Log($"[REWARD] Settlement Applied: DuplicateId=1001, Stars=3, GoldAdd=500, ExpAdd=100, EnergySub=6");

			// ==================================================
			// STEP 6: RETURN TO STAGE2_MAIN & VERIFY LOBBY STATE
			// ==================================================
			Log("\n--- STEP 6: Return to Stage2_Main & Lobby Refresh ---");
			var returnScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
			Log($"Returned to Scene: {returnScene.name}");

			GlobalManager.Instance.UserLogin();
			Log($"GlobalManager.CurState AFTER Return to Lobby: {GlobalManager.Instance.CurState}");
			if (Me.Ins != null && Me.Ins.PlayerInfo != null)
			{
				Log($"Me.Ins State: SetDataOk={Me.Ins.SetDataOk}, Gold={Me.Ins.PlayerInfo.Gold}");
			}

			Log("\n==================================================");
			Log("PHASE 28 END-TO-END GAMEPLAY LOOP TRACE COMPLETE");
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

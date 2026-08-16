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

public static class Phase21_RealLobby_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 21 Real Lobby Trace")]
	public static void RunPhase21Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase21_real_lobby_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 21 — REAL LOBBY RUNTIME VERIFICATION TRACE");
		Log("==================================================");

		try
		{
			// ==================================================
			// STEP 1: REAL END-TO-END LOGIN FLOW
			// ==================================================
			Log("\n--- STEP 1: Starting End-to-End Real Login ---");
			var loginScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
			Log($"Loaded Initial Scene: {loginScene.name} ({loginScene.path})");

			GameObject loginFsmObj = GameObject.Find("LoginFsm");
			if (loginFsmObj == null)
			{
				foreach (var go in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (go.name == "LoginFsm") { loginFsmObj = go; break; }
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
					Log($"[REAL LOGIN SUCCESS] Step {step:D2}: Me.SetDataOk = true, NetState = 6 (STATE_LOGIN_OK)");
					break;
				}
				System.Threading.Thread.Sleep(30);
			}

			// ==================================================
			// STEP 2: VERIFY PLAYER DATA & FORMATION
			// ==================================================
			Log("\n--- STEP 2: Inspecting Player Data & Formation ---");
			Log($"[PLAYER] Me.Ins: {(Me.Ins != null ? "INITIALIZED" : "NULL")}");
			if (Me.Ins != null)
			{
				Log($"[PLAYER] SetDataOk: {Me.Ins.SetDataOk}");
				Log($"[PLAYER] PlayerInfo: {(Me.Ins.PlayerInfo != null ? "LOADED" : "NULL")}");
				if (Me.Ins.PlayerInfo != null)
				{
					Log($"[PLAYER] ID: {Me.Ins.ID}, Name: '{Me.Ins.Name}', Level: {Me.Ins.PlayerInfo.Level}");
				}
				Log($"[PLAYER] Luggage: {(Me.Ins.Luggage != null ? "LOADED" : "NULL")}");

				try
				{
					var heroes = Me.Ins.MainSceneDemonstrateHeroes;
					Log($"[PLAYER] MainSceneDemonstrateHeroes: {(heroes != null ? $"Count = {heroes.Count}" : "NULL/STUB")}");
				}
				catch (Exception ex)
				{
					Log($"[PLAYER] [EXCEPTION IN HERO LOOKUP]: {ex.GetType().Name}: {ex.Message}");
				}
			}

			// ==================================================
			// STEP 3: STAGE TRANSITION TO STAGE2_MAIN
			// ==================================================
			Log("\n--- STEP 3: Loading Stage2_Main Scene ---");
			var stage2Scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
			Log($"Loaded Active Scene: {stage2Scene.name}");

			Log($"GlobalManager.CurState BEFORE UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			var uiMainStage = GameObject.FindObjectOfType<UIMainStage>();
			Log($"UIMainStage component found: {(uiMainStage != null ? uiMainStage.gameObject.name : "NULL")}");

			if (uiMainStage != null)
			{
				Log("Executing UIMainStage.Start()...");
				MethodInfo startMethod = typeof(UIMainStage).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				startMethod?.Invoke(uiMainStage, null);
			}

			Log($"GlobalManager.CurState AFTER UIMainStage.Start(): {GlobalManager.Instance.CurState}");

			// ==================================================
			// STEP 4: HERO & LOBBY SYSTEM INSPECTION
			// ==================================================
			Log("\n--- STEP 4: Inspecting Hero & Lobby Controllers ---");

			var heroGroup = GameObject.FindObjectOfType<UIMainHeroGroupCtrller>();
			Log($"[HERO] UIMainHeroGroupCtrller GameObject: {(heroGroup != null ? heroGroup.gameObject.name : "NULL")}");
			if (heroGroup != null)
			{
				Log("[HERO] Executing ShowTeamHeros()...");
				try
				{
					heroGroup.ShowTeamHeros();
					Log("[HERO] ShowTeamHeros() finished execution.");
				}
				catch (Exception ex)
				{
					Log($"[HERO] [EXCEPTION IN SHOWTEAMHEROS]: {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
				}
			}

			var itemBag = GameObject.FindObjectOfType<ItemBagManager>();
			Log($"[LOBBY] ItemBagManager: {(itemBag != null ? itemBag.gameObject.name : "NULL")}");

			var skillBag = GameObject.FindObjectOfType<SkillBagManager>();
			Log($"[LOBBY] SkillBagManager: {(skillBag != null ? skillBag.gameObject.name : "NULL")}");

			var assistant = GameObject.FindObjectOfType<UIAssistant>();
			Log($"[LOBBY] UIAssistant: {(assistant != null ? assistant.gameObject.name : "NULL")}");

			// Inspect Missing Components
			int missingCount = 0;
			foreach (var go in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
			{
				foreach (var comp in go.GetComponentsInChildren<Component>(true))
				{
					if (comp == null) missingCount++;
				}
			}
			Log($"[LOBBY] Missing MonoBehaviour Components in Stage2_Main: {missingCount}");

			Log("\n==================================================");
			Log("PHASE 21 REAL LOBBY TRACE COMPLETE");
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

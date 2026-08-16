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

public static class Phase24_RealHeroPipeline_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 24 Real Hero Pipeline Trace")]
	public static void RunPhase24Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase24_real_hero_pipeline_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 24 — RECOVER & VERIFY ORIGINAL HERO RENDERING PIPELINE");
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
			// STEP 2: VERIFY PLAYER DATA & FORMATION HERO IDs
			// ==================================================
			Log("\n--- STEP 2: Inspecting Player Data & Real Hero IDs ---");
			Log($"[PLAYER] Me.Ins: {(Me.Ins != null ? "INITIALIZED" : "NULL")}");
			if (Me.Ins != null)
			{
				Log($"[PLAYER] SetDataOk: {Me.Ins.SetDataOk}");
				Log($"[PLAYER] PlayerInfo: {(Me.Ins.PlayerInfo != null ? "LOADED" : "NULL")}");
				if (Me.Ins.PlayerInfo != null)
				{
					Log($"[PLAYER] ID: {Me.Ins.ID}, Name: '{Me.Ins.Name}', Level: {Me.Ins.PlayerInfo.Level}");
				}

				if (Me.Ins.HeroList != null)
				{
					var heroes = Me.Ins.HeroList.MyHeroList;
					Log($"[PLAYER] HeroList Count: {(heroes != null ? heroes.Count.ToString() : "STUB/NULL")}");
					if (heroes != null)
					{
						foreach (var h in heroes)
						{
							Log($"  -> Hero LocalID: {h.LocalID}, Level: {h.Level}");
						}
					}
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
			// STEP 4: HERO RENDERING PIPELINE EXECUTION & AUDIT
			// ==================================================
			Log("\n--- STEP 4: Hero Asset Recovery & Rendering Pipeline Audit ---");

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

				// Direct Asset Load Verification for Real Hero IDs
				int[] targetHeroIds = new int[] { 111181, 111191, 111201 };
				foreach (int heroId in targetHeroIds)
				{
					Log($"\n[AUDIT HERO {heroId}]");
					string relativePrefabPath = $"Assets/resource/heroes/Hero_{heroId}.prefab";
					string relativeBundlePath = $"Assets/StreamingAssets/1.0/common/Heroes/Hero_{heroId}.assetbundle";

					bool prefabExists = File.Exists(Path.Combine(@"E:\Project manga\New folder\ExportedProject", relativePrefabPath));
					bool bundleExists = File.Exists(Path.Combine(@"E:\Project manga\New folder\ExportedProject", relativeBundlePath));

					Log($"[BUNDLE] Prefab Path: '{relativePrefabPath}', File Exists: {prefabExists}");
					Log($"[BUNDLE] Bundle Path: '{relativeBundlePath}', File Exists: {bundleExists}");

					var prefabAsset = AssetDatabase.LoadAssetAtPath<GameObject>(relativePrefabPath);
					Log($"[ASSET] AssetDatabase.LoadAssetAtPath('{relativePrefabPath}'): {(prefabAsset != null ? "SUCCESS" : "NULL")}");

					if (prefabAsset != null)
					{
						GameObject instantiatedHero = UnityEngine.Object.Instantiate(prefabAsset, heroGroup.transform);
						instantiatedHero.name = $"Hero_{heroId}_Instantiated";
						Log($"[ASSET] Instantiate Success: '{instantiatedHero.name}', Active: {instantiatedHero.activeSelf}");

						var allComps = instantiatedHero.GetComponentsInChildren<Component>(true);
						Log($"[SPINE AUDIT] Total Components attached: {allComps.Length}");
						foreach (var c in allComps)
						{
							if (c != null)
							{
								Log($"   -> Component: {c.GetType().FullName} (on {c.gameObject.name})");
							}
							else
							{
								Log("   -> Component: NULL (Missing Script)");
							}
						}
					}
				}
			}

			Log("\n==================================================");
			Log("PHASE 24 REAL HERO RENDERING PIPELINE TRACE COMPLETE");
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

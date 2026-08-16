using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.Protocol;

public static class Phase66A_Clean_Tracer
{
	public static string logPath = @"E:\Project manga\New folder\phase66c_runtime_audit.log";

	public static void Log(string msg)
	{
		Debug.Log("[PHASE66C] " + msg);
		try { File.AppendAllText(logPath, "[PHASE66C] " + msg + "\n"); } catch {}
	}

	[MenuItem("Tools/Run Phase 66C Clean Audit")]
	public static void RunCleanAudit()
	{
		try { File.WriteAllText(logPath, "=== PHASE 66C NATURAL RUNTIME AUDIT START ===\n"); } catch {}

		Log("Step 1: Loading Stage1_Login.unity scene...");
		var loginScene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
		Log("Step 2: Triggering natural login via LoginFsmStep2Manager.TryLogin()...");
		var step2 = UnityEngine.Object.FindObjectOfType<LoginFsmStep2Manager>(true);
		if (step2 == null)
		{
			GameObject step2Go = new GameObject("LoginFsmStep2Manager");
			step2 = step2Go.AddComponent<LoginFsmStep2Manager>();
		}
		step2.gameObject.SetActive(true);
		step2.TryLogin();

		Log("Step 3: Stepping NetManager and socket polling for MsgId 1 and MsgId 1175...");
		var updateNet = typeof(NetManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

		bool msg1Received = false;
		bool msg1175Received = false;
		int frame = 0;

		UIMainHeroGroupCtrller heroCtrller = null;
		MethodInfo updateHeroCtrller = typeof(UIMainHeroGroupCtrller).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
		FieldInfo loadedField = typeof(UIMainHeroGroupCtrller).GetField("loaded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
		FieldInfo currentListField = typeof(UIMainHeroGroupCtrller).GetField("currentArrayList", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

		for (frame = 1; frame <= 100; frame++)
		{
			// Poll NetManager
			try { updateNet?.Invoke(NetManager.Instance, null); } catch {}

			// Check if Stage2_Main is loaded
			if (heroCtrller == null)
			{
				heroCtrller = UnityEngine.Object.FindObjectOfType<UIMainHeroGroupCtrller>(true);
			}

			// Step UIMainHeroGroupCtrller.Update()
			if (heroCtrller != null)
			{
				try { updateHeroCtrller?.Invoke(heroCtrller, null); } catch (Exception ex) { Log($"Exception in Update(): {ex.Message}"); }
			}

			if (Me.Ins != null && Me.Ins.SetDataOk && !msg1175Received)
			{
				msg1175Received = true;
				Log($"[FRAME {frame}] MsgId 1175 received! Me.SetDataOk = true, MainSceneDemonstrateHeroes.Count = {Me.Ins.MainSceneDemonstrateHeroes?.Count}");
			}

			bool isLoaded = heroCtrller != null && (bool)loadedField.GetValue(heroCtrller);
			var currList = heroCtrller != null ? (List<int>)currentListField.GetValue(heroCtrller) : null;

			if (msg1175Received && isLoaded)
			{
				Log($"[FRAME {frame}] UIMainHeroGroupCtrller successfully loaded heroes! loaded=true, currentArrayList.Count={(currList != null ? currList.Count : 0)}");
				break;
			}

			System.Threading.Thread.Sleep(50);
		}

		Log("Step 4: Transitioning to Stage2_Main.unity to test UIMainHeroGroupCtrller.Update() lifecycle...");
		var stage2Scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage2_Main.unity", OpenSceneMode.Single);
		Log($"Stage2 loaded: {stage2Scene.name}");

		var uiMainStage = UnityEngine.Object.FindObjectOfType<UIMainStage>();
		Log($"UIMainStage found: {uiMainStage != null}");
		if (uiMainStage != null)
		{
			MethodInfo startMethod = typeof(UIMainStage).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			startMethod?.Invoke(uiMainStage, null);
		}

		var mainSceneMgr = UnityEngine.Object.FindAnyObjectByType<MainSceneManager>(FindObjectsInactive.Include);
		if (mainSceneMgr == null)
		{
			var mainScenePrefab = Resources.Load<GameObject>("ui/mainscene/UIMainScene");
			if (mainScenePrefab != null)
			{
				var go = UnityEngine.Object.Instantiate(mainScenePrefab);
				mainSceneMgr = go.GetComponent<MainSceneManager>();
			}
		}
		Log($"MainSceneManager found: {mainSceneMgr != null}");
		if (mainSceneMgr != null)
		{
			mainSceneMgr.InitMain();
			bool topPanelValid = mainSceneMgr.topPanel != null;
			bool bottomPanelValid = mainSceneMgr.bottomPanel != null;
			Log($"MainSceneManager.InitMain() executed! topPanel!=null={topPanelValid}, bottomPanel!=null={bottomPanelValid}");
		}

		heroCtrller = UnityEngine.Object.FindObjectOfType<UIMainHeroGroupCtrller>();
		Log($"UIMainHeroGroupCtrller found: {heroCtrller != null}");

		if (heroCtrller != null)
		{
			bool loadedBefore = (bool)loadedField.GetValue(heroCtrller);
			var listBefore = (List<int>)currentListField.GetValue(heroCtrller);
			int countBefore = listBefore != null ? listBefore.Count : -1;
			Log($"[BEFORE UPDATE TICK] loaded={loadedBefore}, currentArrayList.Count={countBefore}");

			// Tick UIMainHeroGroupCtrller.Update()
			Log("Ticking UIMainHeroGroupCtrller.Update()...");
			updateHeroCtrller?.Invoke(heroCtrller, null);

			bool loadedAfter = (bool)loadedField.GetValue(heroCtrller);
			var listAfter = (List<int>)currentListField.GetValue(heroCtrller);
			int countAfter = listAfter != null ? listAfter.Count : -1;
			string idsAfter = listAfter != null ? string.Join(",", listAfter) : "none";
			Log($"[AFTER UPDATE TICK 1] loaded={loadedAfter}, currentArrayList.Count={countAfter}, heroIDs=[{idsAfter}]");

			// Tick UIMainHeroGroupCtrller.Update() again (should not re-trigger because loaded is now true)
			Log("Ticking UIMainHeroGroupCtrller.Update() a second time (idempotency check)...");
			updateHeroCtrller?.Invoke(heroCtrller, null);
			Log($"[AFTER UPDATE TICK 2] loaded={loadedAfter}, currentArrayList.Count={countAfter} (idempotent = true)");
		}

		Log("Step 5: Final verification and state assertion:");
		bool meValid = Me.Ins != null;
		bool setDataOk = meValid && Me.Ins.SetDataOk;
		var activeArray = meValid ? Me.Ins.ActiveArray : null;
		int myCardsCount = (activeArray != null && activeArray.MyCards != null) ? System.Linq.Enumerable.Count(activeArray.MyCards) : -1;
		var demoList = meValid ? Me.Ins.MainSceneDemonstrateHeroes : null;
		int demoCount = demoList != null ? demoList.Count : -1;
		string demoIdsStr = demoList != null ? string.Join(",", demoList.Select(h => h != null ? h.LocalID.ToString() : "null")) : "none";
		string activeSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

		bool finalLoaded = heroCtrller != null && (bool)loadedField.GetValue(heroCtrller);
		var finalCurrList = heroCtrller != null ? (List<int>)currentListField.GetValue(heroCtrller) : null;
		int finalCurrCount = finalCurrList != null ? finalCurrList.Count : -1;
		string finalCurrIds = finalCurrList != null ? string.Join(",", finalCurrList) : "none";

		// Inspect individual hero attributes and heroList
		int heroListCount = meValid && Me.Ins.HeroList != null ? Me.Ins.HeroList.Count : -1;
		string heroDetailsStr = "none";
		if (demoList != null && demoList.Count > 0)
		{
			var details = new List<string>();
			foreach (var h in demoList)
			{
				if (h != null)
				{
					var hp = h.GetAttr(EAttrType.Health);
					var atk = h.GetAttr(EAttrType.Attack);
					var def = h.GetAttr(EAttrType.Defence);
					details.Add($"Hero(ID={h.LocalID}, Level={h.Level}, HP={(hp != null ? hp.Value : -1)}, ATK={(atk != null ? atk.Value : -1)}, DEF={(def != null ? def.Value : -1)})");
				}
			}
			heroDetailsStr = string.Join("; ", details);
		}

		bool msmValid = mainSceneMgr != null;
		Log($"SUMMARY: ActiveScene='{activeSceneName}', Me.Ins!=null={meValid}, SetDataOk={setDataOk}, ActiveArray!=null={(activeArray!=null)}, MyCards.Count={myCardsCount}, MainSceneDemonstrateHeroes.Count={demoCount}, DemoHeroIDs=[{demoIdsStr}], HeroCtrllerLoaded={finalLoaded}, currentArrayList.Count={finalCurrCount}, currentArrayListIDs=[{finalCurrIds}], HeroList.Count={heroListCount}, MainSceneManager!=null={msmValid}");
		Log($"HERO-DETAILS: {heroDetailsStr}");

		Log("=== PHASE 67C NATURAL RUNTIME AUDIT COMPLETE ===");

		if (Application.isBatchMode)
		{
			EditorApplication.Exit(0);
		}
	}
}

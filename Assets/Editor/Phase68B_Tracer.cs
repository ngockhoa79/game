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
using Ice.ProjectCos.UI.Intents;
using Ice.ProjectCos.Protocol;

public static class Phase68B_Tracer
{
	public static string logPath = @"E:\Project manga\New folder\phase68b_runtime_audit.log";

	public static void Log(string msg)
	{
		Debug.Log("[PHASE68B] " + msg);
		try { File.AppendAllText(logPath, "[PHASE68B] " + msg + "\n"); } catch {}
	}

	[MenuItem("Tools/Run Phase 68B Clean Audit")]
	public static void RunAudit()
	{
		try { File.WriteAllText(logPath, "=== PHASE 68B NATURAL RUNTIME AUDIT START ===\n"); } catch {}

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

		bool msg1175Received = false;
		int frame = 0;

		UIMainHeroGroupCtrller heroCtrller = null;
		MethodInfo updateHeroCtrller = typeof(UIMainHeroGroupCtrller).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
		FieldInfo loadedField = typeof(UIMainHeroGroupCtrller).GetField("loaded", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
		FieldInfo currentListField = typeof(UIMainHeroGroupCtrller).GetField("currentArrayList", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

		for (frame = 1; frame <= 100; frame++)
		{
			try { updateNet?.Invoke(NetManager.Instance, null); } catch {}

			if (heroCtrller == null)
			{
				heroCtrller = UnityEngine.Object.FindObjectOfType<UIMainHeroGroupCtrller>(true);
			}

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

		Log("Step 4: Transitioning to Stage2_Main.unity to test Stage2 baseline...");
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
		if (heroCtrller != null)
		{
			updateHeroCtrller?.Invoke(heroCtrller, null);
		}

		// Verify Phase 67B/67C Baseline
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
		int heroListCount = meValid && Me.Ins.HeroList != null ? Me.Ins.HeroList.Count : -1;
		bool msmValid = mainSceneMgr != null;

		Log($"BASELINE VERIFICATION: ActiveScene='{activeSceneName}', Me.Ins!=null={meValid}, SetDataOk={setDataOk}, ActiveArray!=null={(activeArray!=null)}, MyCards.Count={myCardsCount}, MainSceneDemonstrateHeroes.Count={demoCount}, DemoHeroIDs=[{demoIdsStr}], HeroCtrllerLoaded={finalLoaded}, currentArrayList.Count={finalCurrCount}, HeroList.Count={heroListCount}, MainSceneManager!=null={msmValid}");

		// Create IceUIPanelCollector if needed
		var collector = UnityEngine.Object.FindObjectOfType<IceUIPanelCollector>();
		if (collector == null)
		{
			GameObject colGo = new GameObject("IceUIPanelCollector");
			collector = colGo.AddComponent<IceUIPanelCollector>();
		}
		Log($"IceUIPanelCollector present: {collector != null}");

		// Reset IntentStack for clean test
		IntentStack.ClearStack();

		// STEP 5: TEST A — CARD BAG (CouponIntents)
		Log("Step 5: Executing TEST A — CARD BAG navigation...");
		int stackBeforeA = IntentStack.GetIntentsCount();
		uiMainStage.activateCardBag();
		int stackAfterA = IntentStack.GetIntentsCount();
		Intent topA = IntentStack.Peek();
		string topTypeNameA = topA != null ? topA.GetType().Name : "null";
		bool isPresentA = topA != null && topA.IsPresent;
		bool isInitedA = topA != null && topA.IsInited;
		Log($"TEST A RESULT: StackCount={stackAfterA} (delta={stackAfterA - stackBeforeA}), TopIntent='{topTypeNameA}', IsInited={isInitedA}, IsPresent={isPresentA}");

		// STEP 6: TEST B — ARRAY EDITOR (ArrayEditorIntent)
		Log("Step 6: Executing TEST B — ARRAY EDITOR navigation...");
		int stackBeforeB = IntentStack.GetIntentsCount();
		uiMainStage.activateArrayEditor();
		int stackAfterB = IntentStack.GetIntentsCount();
		Intent topB = IntentStack.Peek();
		string topTypeNameB = topB != null ? topB.GetType().Name : "null";
		bool isPresentB = topB != null && topB.IsPresent;
		bool isInitedB = topB != null && topB.IsInited;
		Log($"TEST B RESULT: StackCount={stackAfterB} (delta={stackAfterB - stackBeforeB}), TopIntent='{topTypeNameB}', IsInited={isInitedB}, IsPresent={isPresentB}");

		// STEP 7: TEST C — LUGGAGE (LuggageIntents)
		Log("Step 7: Executing TEST C — LUGGAGE navigation...");
		int stackBeforeC = IntentStack.GetIntentsCount();
		uiMainStage.activateGearLuggage();
		int stackAfterC = IntentStack.GetIntentsCount();
		Intent topC = IntentStack.Peek();
		string topTypeNameC = topC != null ? topC.GetType().Name : "null";
		bool isPresentC = topC != null && topC.IsPresent;
		bool isInitedC = topC != null && topC.IsInited;
		Log($"TEST C RESULT: StackCount={stackAfterC} (delta={stackAfterC - stackBeforeC}), TopIntent='{topTypeNameC}', IsInited={isInitedC}, IsPresent={isPresentC}");

		// STEP 8: TEST D — REVOKE LUGGAGE
		Log("Step 8: Executing TEST D — REVOKE LUGGAGE (pop top intent)...");
		int stackBeforeD = IntentStack.GetIntentsCount();
		topC?.Revoke(null);
		int stackAfterD = IntentStack.GetIntentsCount();
		Intent topD = IntentStack.Peek();
		string topTypeNameD = topD != null ? topD.GetType().Name : "null";
		bool isPresentD = topD != null && topD.IsPresent;
		bool isInitedD = topD != null && topD.IsInited;
		Log($"TEST D RESULT: StackCount={stackAfterD} (delta={stackAfterD - stackBeforeD}), TopIntent='{topTypeNameD}', IsInited={isInitedD}, IsPresent={isPresentD}");

		Log("=== PHASE 68B NATURAL RUNTIME AUDIT COMPLETE ===");

		if (Application.isBatchMode)
		{
			EditorApplication.Exit(0);
		}
	}
}

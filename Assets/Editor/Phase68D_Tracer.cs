using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using Ice.ProjectCos.UI.Intents;
using Ice.ProjectCos.UI.DataModel;

public static class Phase68D_Tracer
{
	private static readonly string LogPath = "e:/Project manga/New folder/phase68d_runtime_audit.log";

	private static void Log(string msg)
	{
		string text = $"[PHASE68D] {msg}";
		Debug.Log(text);
		File.AppendAllText(LogPath, text + "\n");
	}

	public static void RunAudit()
	{
		if (File.Exists(LogPath))
		{
			File.Delete(LogPath);
		}

		File.AppendAllText(LogPath, "=== PHASE 68D BATCH 1 NATURAL RUNTIME AUDIT START ===\n");
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

		heroCtrller = (uiMainStage != null) ? uiMainStage.uiMainHeroGroupCtrller : UnityEngine.Object.FindObjectOfType<UIMainHeroGroupCtrller>(true);
		if (heroCtrller != null)
		{
			try { updateHeroCtrller?.Invoke(heroCtrller, null); } catch {}
		}

		// BASELINE VERIFICATION
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

		// STEP 5: TEST A — MAIL (MailIntent)
		Log("Step 5: Executing TEST A — MAIL navigation...");
		int initialCount = IntentStack.GetIntentsCount();
		if (mainSceneMgr != null)
		{
			mainSceneMgr.activeMail();
		}
		else
		{
			new MailIntent().Perform(null, true, true, false, true);
		}

		Intent topMail = IntentStack.Peek();
		bool mailPanelNotNull = topMail != null && topMail.Panel() != null;
		bool mailGoActive = mailPanelNotNull && topMail.Panel().gameObject.activeSelf;
		bool mailCtrlExists = topMail != null && topMail.Panel<UIMail>() != null;

		Log($"TEST A RESULT: StackCount={IntentStack.GetIntentsCount()} (delta={IntentStack.GetIntentsCount() - initialCount}), " +
			$"TopIntent='{topMail?.GetType().Name}', " +
			$"IsInited={topMail?.IsInited}, " +
			$"IsPresent={topMail?.IsPresent}, " +
			$"PanelNotNull={mailPanelNotNull}, " +
			$"PanelActive={mailGoActive}, " +
			$"UIMailExists={mailCtrlExists}");

		// STEP 6: TEST B — MAIL REVOKE
		Log("Step 6: Executing TEST B — MAIL REVOKE...");
		IntentStack.RevokeCurrentIntent(null);
		Log($"TEST B RESULT: StackCount={IntentStack.GetIntentsCount()}, TopIntent='{IntentStack.Peek()?.GetType().Name}'");

		// STEP 7: TEST C — TASK (TaskAchiveIntent)
		Log("Step 7: Executing TEST C — TASK navigation...");
		initialCount = IntentStack.GetIntentsCount();
		if (mainSceneMgr != null)
		{
			mainSceneMgr.activeTask();
		}
		else
		{
			new TaskAchiveIntent().Perform(null, true, true, false, true);
		}

		Intent topTask = IntentStack.Peek();
		bool taskPanelNotNull = topTask != null && topTask.Panel() != null;
		bool taskGoActive = taskPanelNotNull && topTask.Panel().gameObject.activeSelf;
		bool taskCtrlExists = topTask != null && topTask.Panel<UITaskAchive>() != null;

		Log($"TEST C RESULT: StackCount={IntentStack.GetIntentsCount()} (delta={IntentStack.GetIntentsCount() - initialCount}), " +
			$"TopIntent='{topTask?.GetType().Name}', " +
			$"IsInited={topTask?.IsInited}, " +
			$"IsPresent={topTask?.IsPresent}, " +
			$"PanelNotNull={taskPanelNotNull}, " +
			$"PanelActive={taskGoActive}, " +
			$"UITaskAchiveExists={taskCtrlExists}");

		// STEP 8: TEST D — TASK REVOKE
		Log("Step 8: Executing TEST D — TASK REVOKE...");
		IntentStack.RevokeCurrentIntent(null);
		Log($"TEST D RESULT: StackCount={IntentStack.GetIntentsCount()}, TopIntent='{IntentStack.Peek()?.GetType().Name}'");

		// STEP 9: PHASE 68B REGRESSION TEST
		Log("Step 9: Executing PHASE 68B REGRESSION TEST (Coupon -> ArrayEditor -> Luggage -> Revoke)...");
		if (uiMainStage != null)
		{
			uiMainStage.activateCardBag();
		}
		int reg1 = IntentStack.GetIntentsCount();
		string top1 = IntentStack.Peek()?.GetType().Name;

		if (uiMainStage != null)
		{
			uiMainStage.activateArrayEditor();
		}
		int reg2 = IntentStack.GetIntentsCount();
		string top2 = IntentStack.Peek()?.GetType().Name;

		if (uiMainStage != null)
		{
			uiMainStage.activateLuggage();
		}
		int reg3 = IntentStack.GetIntentsCount();
		string top3 = IntentStack.Peek()?.GetType().Name;

		IntentStack.RevokeCurrentIntent(null);
		int reg4 = IntentStack.GetIntentsCount();
		string top4 = IntentStack.Peek()?.GetType().Name;

		Log($"REGRESSION TEST RESULT: Step1(CardBag)=[{reg1},{top1}], Step2(Array)=[{reg2},{top2}], Step3(Luggage)=[{reg3},{top3}], Step4(Revoke)=[{reg4},{top4}]");

		Log("=== PHASE 68D BATCH 1 NATURAL RUNTIME AUDIT COMPLETE ===");
	}
}

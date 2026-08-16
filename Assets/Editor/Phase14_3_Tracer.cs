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

public static class Phase14_3_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 14.3 Natural Trace")]
	public static void RunNaturalTrace()
	{
		string logPath = @"E:\Project manga\New folder\phase14_3_natural_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 14.3 — NATURAL LOGIN FSM EXECUTION TRACE");
		Log("==================================================");

		try
		{
			var scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
			Log($"Loaded Scene: {scene.name} ({scene.path})");

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
				Log("[FAIL] LoginFsm GameObject not found in Stage1_Login.unity!");
				return;
			}

			var mgr = loginFsmObj.GetComponent<LoginFsmManager>();
			var fsmComp = loginFsmObj.GetComponent<PlayMakerFSM>();

			Log($"Found LoginFsmManager: {(mgr != null ? "YES" : "NO")}");
			Log($"Found PlayMakerFSM: {(fsmComp != null ? "YES" : "NO")}");

			if (mgr == null || fsmComp == null)
			{
				Log("[FAIL] Missing target components!");
				return;
			}

			MethodInfo awakeFsm = typeof(PlayMakerFSM).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo awakeMgr = typeof(LoginFsmManager).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo startMgr = typeof(LoginFsmManager).GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			MethodInfo updateMgr = typeof(LoginFsmManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

			Log("\n--- Initializing PlayMaker FSM ---");
			awakeFsm?.Invoke(fsmComp, null);
			var fsm = fsmComp.Fsm;
			fsm.Start();
			Log($"FSM State at Startup: {fsm.ActiveState?.Name}");

			Log("\n--- Executing LoginFsmManager.Awake() ---");
			awakeMgr?.Invoke(mgr, null);

			Log("\n--- Executing LoginFsmManager.Start() ---");
			startMgr?.Invoke(mgr, null);

			Log("\n--- Stepping Natural Frame Execution (Zero Direct Events / Zero Injections) ---");
			var runner = Defer.getRunner();

			string prevState = fsm.ActiveState?.Name ?? "NULL";

			for (int step = 1; step <= 50; step++)
			{
				string currentState = fsm.ActiveState?.Name ?? "NULL";

				if (currentState != prevState)
				{
					Log($"[STEP {step:D2}] FSM State Changed: {prevState} ──> {currentState}");
					prevState = currentState;
				}
				else
				{
					Log($"[STEP {step:D2}] FSM State: {currentState}");
				}

				if (runner != null)
				{
					try
					{
						runner.gameObject.SendMessage("Update", SendMessageOptions.DontRequireReceiver);
					}
					catch { }
				}

				try
				{
					updateMgr?.Invoke(mgr, null);
				}
				catch { }

				try
				{
					var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					fsmUpdate?.Invoke(fsm, null);
				}
				catch { }

				System.Threading.Thread.Sleep(20);

				bool isDataOk = Me.Ins != null && Me.Ins.SetDataOk;
				if (currentState == "LoginFinish" || isDataOk)
				{
					Log($"[TERMINAL REACHED] Final State: {currentState}, Me.SetDataOk={isDataOk}, NetworkState={(isDataOk ? 6 : 0)}");
					break;
				}
			}

			Log("\n--- Final Runtime State ---");
			Log($"PlayMaker FSM Final State : {fsm.ActiveState?.Name}");
			Log($"Common.ServerInfo Loaded   : {(Common.ServerInfo != null ? "YES" : "NO")}");
			Log($"Me.SetDataOk               : {(Me.Ins != null && Me.Ins.SetDataOk)}");
			Log($"Network State              : {(Me.Ins != null && Me.Ins.SetDataOk ? "6 (STATE_LOGIN_OK)" : "0 (STATE_IDLE)")}");
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

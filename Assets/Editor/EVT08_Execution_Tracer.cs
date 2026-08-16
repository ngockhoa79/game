using System;
using System.IO;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.Protocol;

public static class EVT08_Execution_Tracer
{
	private static string logPath = @"E:\Project manga\New folder\evt08_draw_results.log";

	private static void Log(string msg)
	{
		Debug.Log("[EVT08] " + msg);
		File.AppendAllText(logPath, msg + "\n");
	}
	public static float startTime = 0f;

	[MenuItem("Tools/Run EVT-08 Gate 2 Test")]
	public static void RunEVT08()
	{
		startTime = Time.realtimeSinceStartup;
		File.WriteAllText(logPath, "=== EVT-08 GATE 2 EXECUTION TRACE START ===\n");
		Log("Initializing EVT-08 single 10x draw execution test in PlayMode...");

		EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity");
		EditorApplication.isPlaying = true;
	}
}

[InitializeOnLoad]
public class EVT08_PlayMode_Runner
{
	private static string logPath = @"E:\Project manga\New folder\evt08_draw_results.log";
	private static bool executed = false;
	private static float timer = 0f;

	private static void Log(string msg)
	{
		Debug.Log("[EVT08] " + msg);
		File.AppendAllText(logPath, msg + "\n");
	}

	static EVT08_PlayMode_Runner()
	{
		// Disabled for Phase 66A clean natural runtime forensic audit
		// EditorApplication.update += OnEditorUpdate;
	}

	private static void OnEditorUpdate()
	{
		// Timeout safeguard for batchmode
		if (Application.isBatchMode && (Time.realtimeSinceStartup - EVT08_Execution_Tracer.startTime) > 120f)
		{
			Log("TIMEOUT: Test exceeded 120 seconds. Force quitting.");
			EditorApplication.Exit(1);
			return;
		}

		if (!EditorApplication.isPlaying || executed) return;

		timer += 0.05f;

		// Stage 1: Trigger Login after 2 seconds in PlayMode
		if (timer > 2.0f && timer < 2.2f)
		{
			var step2 = UnityEngine.Object.FindObjectOfType<LoginFsmStep2Manager>(true);
			if (step2 != null)
			{
				Log("Triggering LoginFsmStep2Manager.TryLogin()...");
				step2.gameObject.SetActive(true);
				step2.TryLogin();
			}
		}

		// Stage 2: Trigger DrawCard once login data is ready
		if (timer > 4.5f && Me.Ins != null && Me.Ins.SetDataOk && !executed)
		{
			executed = true; // Prevent double execution

			int crystalBefore = Me.Ins.PlayerInfo != null ? Me.Ins.PlayerInfo.Crystal : -1;
			int heroCountBefore = Me.Ins.HeroList != null ? Me.Ins.HeroList.Count : -1;
			int pityBefore = DrawCardMoudle.DrawCardInfo != null ? DrawCardMoudle.DrawCardInfo.TryDiamondMustGetPurpleCount : -1;

			Log($"PRE-DRAW STATE: CrystalBefore={crystalBefore}, HeroCountBefore={heroCountBefore}, PityBefore={pityBefore}");

			Log("Performing EXACTLY ONE 10x Diamond draw via DrawCardMoudle.drawCardByDiamond10...");

			DrawCardMoudle.drawCardByDiamond10(
				(results) => {
					Log($"DRAW SUCCESS! Result item count: {results.Count}");
					for (int i = 0; i < results.Count; i++)
					{
						var item = results[i];
						Log($"RESULT #{i+1}: LocalID={item.LocalID}, Count={item.Count}");
					}

					int crystalAfter = Me.Ins.PlayerInfo != null ? Me.Ins.PlayerInfo.Crystal : -1;
					int heroCountAfter = Me.Ins.HeroList != null ? Me.Ins.HeroList.Count : -1;
					int pityAfter = DrawCardMoudle.DrawCardInfo != null ? DrawCardMoudle.DrawCardInfo.TryDiamondMustGetPurpleCount : -1;

					Log($"POST-DRAW STATE: CrystalAfter={crystalAfter}, HeroCountAfter={heroCountAfter}, PityAfter={pityAfter}");
					Log($"ECONOMY DELTA: CrystalDelta={crystalBefore - crystalAfter} (Expected: 2700)");
					Log("=== EVT-08 GATE 2 EXECUTION TRACE COMPLETE ===");

					EditorApplication.isPlaying = false;
					if (Application.isBatchMode) EditorApplication.Exit(0);
				},
				() => {
					Log("FAIL: Draw operation returned failure callback from server!");
					EditorApplication.isPlaying = false;
					if (Application.isBatchMode) EditorApplication.Exit(1);
				}
			);
		}
	}
}

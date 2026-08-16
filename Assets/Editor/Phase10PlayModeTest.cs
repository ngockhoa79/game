using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public static class Phase10PlayModeTest
{
	private static string logPath = "E:/Project manga/New folder/unity_phase10.log";

	static Phase10PlayModeTest()
	{
		// Disabled for Phase 66A clean natural runtime forensic audit
		// EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
	}

	[MenuItem("Phase10/Run Play Mode Test")]
	public static void RunPlayModeTest()
	{
		File.WriteAllText(logPath, "=== PHASE 10 REAL PLAY MODE TEST START ===\n");
		Application.logMessageReceived += LogCallback;

		Debug.Log("[PHASE10-TEST] Loading Stage1_Login.unity scene...");
		EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity");
		EditorApplication.isPlaying = true;
	}

	private static void OnPlayModeStateChanged(PlayModeStateChange state)
	{
		if (state == PlayModeStateChange.EnteredPlayMode)
		{
			Debug.Log("[PHASE10-TEST] Entered Play Mode naturally.");
			EditorApplication.delayCall += () =>
			{
				var step2 = UnityEngine.Object.FindObjectOfType<LoginFsmStep2Manager>(true);
				if (step2 != null)
				{
					Debug.Log("[PHASE10-TEST] Found LoginFsmStep2Manager on scene. Invoking TryLogin()...");
					step2.gameObject.SetActive(true);
					step2.TryLogin();
				}
				else
				{
					Debug.LogError("[PHASE10-TEST] LoginFsmStep2Manager not found on scene!");
				}
			};
		}
	}

	private static void LogCallback(string logString, string stackTrace, LogType type)
	{
		try
		{
			File.AppendAllText(logPath, $"[{DateTime.Now:HH:mm:ss.fff}] [{type}] {logString}\n");
		}
		catch { }
	}
}

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.Protocol;

[InitializeOnLoad]
public static class Phase65_Baseline_Tracer
{
	private static string flagPath = @"E:\Project manga\New folder\run_baseline.flag";

	static Phase65_Baseline_Tracer()
	{
		// Disabled for Phase 66A clean natural runtime forensic audit
		// EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
		EditorApplication.delayCall += CheckFlag;
	}

	private static void CheckFlag()
	{
		if (File.Exists(flagPath) && !EditorApplication.isPlayingOrWillChangePlaymode)
		{
			File.Delete(flagPath);
			RunBaseline();
		}
	}

	[MenuItem("Tools/Run Phase 65 Baseline")]
	public static void RunBaseline()
	{
		Debug.Log("=== PHASE 65 BASELINE RUNTIME TEST START ===");
		Debug.Log("[PHASE65] Loading Stage1_Login.unity scene...");
		EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity");
		EditorApplication.isPlaying = true;
	}

	private static void OnPlayModeStateChanged(PlayModeStateChange state)
	{
		if (state == PlayModeStateChange.EnteredPlayMode)
		{
			Debug.Log("[PHASE65] Entered Play Mode.");
			GameObject go = new GameObject("Phase65Runner");
			go.AddComponent<Phase65RunnerBehaviour>();
		}
		else if (state == PlayModeStateChange.ExitingPlayMode)
		{
		}
	}
}

public class Phase65RunnerBehaviour : MonoBehaviour
{
	IEnumerator Start()
	{
		yield return new WaitForSeconds(2);
		
		var step2 = UnityEngine.Object.FindObjectOfType<LoginFsmStep2Manager>(true);
		if (step2 != null)
		{
			Debug.Log("[PHASE65] Found LoginFsmStep2Manager on scene. Invoking TryLogin()...");
			step2.gameObject.SetActive(true);
			step2.TryLogin();
		}
		else
		{
			Debug.LogError("[PHASE65] LoginFsmStep2Manager not found!");
		}
		
		// Wait for login and scene transition
		yield return new WaitForSeconds(8);
		
		Debug.Log("[PHASE65] Checking Me.Ins and MainSceneDemonstrateHeroes...");
		if (Me.Ins == null)
		{
			Debug.LogError("[PHASE65] Me.Ins is null! Login failed or player not loaded.");
		}
		else if (Me.Ins.MainSceneDemonstrateHeroes == null)
		{
			Debug.LogError("[PHASE65] MainSceneDemonstrateHeroes is null!");
		}
		else
		{
			Debug.Log($"[PHASE65] MainSceneDemonstrateHeroes count: {Me.Ins.MainSceneDemonstrateHeroes.Count}");
			foreach (var hero in Me.Ins.MainSceneDemonstrateHeroes)
			{
				Debug.Log($"[PHASE65] Demo Hero: LocalID={hero.LocalID}");
			}
		}

		// Look for UIMainHeroGroupCtrller
		var heroGroupCtrller = UnityEngine.Object.FindObjectOfType<UIMainHeroGroupCtrller>(true);
		if (heroGroupCtrller != null)
		{
			Debug.Log("[PHASE65] UIMainHeroGroupCtrller found.");
		}
		else
		{
			Debug.LogError("[PHASE65] UIMainHeroGroupCtrller not found in Main Scene!");
		}

		yield return new WaitForSeconds(2);
		Debug.Log("[PHASE65] Baseline test complete. Exiting Play Mode.");
		EditorApplication.isPlaying = false;
	}
}

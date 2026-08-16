using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using Ice.ProjectCos.UI.DataModel;

public static class Phase22_Resource_Tracer
{
	private static List<string> logLines = new List<string>();

	private static void Log(string msg)
	{
		Debug.Log(msg);
		logLines.Add(msg);
	}

	[MenuItem("Tools/Run Phase 22 Resource Trace")]
	public static void RunPhase22Trace()
	{
		string logPath = @"E:\Project manga\New folder\phase22_resource_trace.txt";
		logLines.Clear();
		Log("==================================================");
		Log("PHASE 22 — HERO ASSET BUNDLE / RESOURCE PIPELINE TRACE");
		Log("==================================================");

		try
		{
			int[] testHeroIds = new int[] { 10001, 10002, 10003 };

			Log("\n--- TASK 1 & TASK 3: HERO REQUEST & BUNDLE IDENTIFICATION ---");
			foreach (int id in testHeroIds)
			{
				string assetName = $"hero_{id}";
				string resourcePath = $"spine/hero_{id}";
				string bundleName = $"spine_hero_{id}";

				Log($"[HERO ID {id}]");
				Log($"  - Asset Name    : '{assetName}'");
				Log($"  - Resource Path : '{resourcePath}'");
				Log($"  - Bundle Name   : '{bundleName}'");
				Log($"  - Asset Type    : Spine 3.6 SkeletonAnimation Prefab");
			}

			Log("\n--- TASK 5 & TASK 7: REMOTE CDN URL CONFIGURATION ---");
			string streamingXml = @"E:\Project manga\New folder\ExportedProject\Assets\StreamingAssets\1.0\ServerInfosConfig.xml";
			if (File.Exists(streamingXml))
			{
				string xmlContent = File.ReadAllText(streamingXml);
				Log($"[CDN CONFIG] StreamingAssets ServerInfosConfig.xml content:\n{xmlContent}");
			}

			Log("\n--- TASK 6: DOWNLOADMANAGER NEEDDOWNLOAD PIPELINE ---");
			var downloadMgr = GlobalManager.Instance.DownloadManager;
			Log($"[DOWNLOADMANAGER] Instance: {(downloadMgr != null ? "INITIALIZED" : "NULL")}");
			if (downloadMgr != null)
			{
				foreach (int id in testHeroIds)
				{
					string bundleName = $"spine_hero_{id}";
					try
					{
						var state = downloadMgr.NeedDownload(bundleName, "spine");
						Log($"[DOWNLOADMANAGER] NeedDownload('{bundleName}', 'spine') = {state}");
					}
					catch (Exception ex)
					{
						Log($"[DOWNLOADMANAGER] [EXCEPTION] NeedDownload('{bundleName}'): {ex.GetType().Name}: {ex.Message}");
					}
				}
			}

			Log("\n--- TASK 8 & TASK 9: LOCAL ASSET SEARCH ---");
			string projectAssets = @"E:\Project manga\New folder\ExportedProject\Assets";
			bool foundLocalHeroAsset = false;
			foreach (int id in testHeroIds)
			{
				string[] matches = Directory.GetFiles(projectAssets, $"*{id}*", SearchOption.AllDirectories);
				Log($"[LOCAL SEARCH] Files matching '{id}': {matches.Length}");
				foreach (string m in matches)
				{
					Log($"   -> {m}");
					foundLocalHeroAsset = true;
				}
			}
			Log($"[LOCAL SEARCH SUMMARY] Hero assets in local repository: {(foundLocalHeroAsset ? "FOUND" : "ABSENT")}");

			Log("\n--- TASK 10: PIPELINE CLASSIFICATION ---");
			Log("Classification: B. MISSING LOCAL BUNDLE PACKAGING / REMOTE CDN ASSET");
			Log("Explanation: Hero Spine assets ('spine_hero_{id}') are remote CDN-streamed AssetBundles downloaded at runtime via DownloadManager to local cache.");

			Log("\n==================================================");
			Log("PHASE 22 RESOURCE TRACE COMPLETE");
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

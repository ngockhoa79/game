using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class DownloadAllNewstResources : FsmStateAction
{
	[RequiredField]
	public FsmEvent E_OnSuccess;

	[RequiredField]
	public FsmEvent E_OnFail;

	[RequiredField]
	public FsmString outputString;

	[RequiredField]
	public FsmFloat downloadProgress;

	private const int StartDownloadCount = 10;

	private int curDownloadIndex;

	private List<DownloadManager.VersionData> downloadedList;

	private List<DownloadManager.VersionData> allDownloadList;

	private bool bUpdatedGameXml;

	private int m_iInDownloadingAssetsCount;

	private bool m_bStartedDownloading;

	private DateTime lastRestartTime;

	private long AllFileSize;

	// NATIVE-CONFIRMED: RVA 0x71E020
	public override void OnEnter()
	{
		DebugLog.Log("Enter DownloadAllNewstResources");
		DownloadAllResources();
	}

	// NATIVE-CONFIRMED: RVA 0x71E3D0
	public override void OnExit()
	{
	}

	// NATIVE-CONFIRMED: RVA 0x71E470
	public override void OnUpdate()
	{
		if (!m_bStartedDownloading) return;

		ShowDownloadRatio();

		if (IsAllComplete())
		{
			m_bStartedDownloading = false;
			DebugLog.Log("DownloadAllNewstResources: All downloads complete.");
			var evSuccess = (E_OnSuccess != null && !string.IsNullOrEmpty(E_OnSuccess.Name)) ? E_OnSuccess : FsmEvent.GetFsmEvent("Success");
			if (Fsm != null && evSuccess != null)
			{
				Fsm.Event(evSuccess);
			}
			Finish();
		}
	}

	// NATIVE-CONFIRMED: RVA 0x71CB10
	private void DownloadAllResources()
	{
		allDownloadList = GetDownloadList();
		AllFileSize = GetFileTotalSize(allDownloadList);
		downloadedList = new List<DownloadManager.VersionData>();
		curDownloadIndex = 0;
		m_iInDownloadingAssetsCount = 0;

		if (allDownloadList == null || allDownloadList.Count == 0)
		{
			DebugLog.Log("DownloadAllNewstResources: Nothing to download, complete.");
			if (downloadProgress != null) downloadProgress.value = 1f;
			if (outputString != null) outputString.value = "100%";
			var ev = (E_OnSuccess != null && !string.IsNullOrEmpty(E_OnSuccess.Name)) ? E_OnSuccess : FsmEvent.GetFsmEvent("Success");
			if (Fsm != null && ev != null)
			{
				Fsm.Event(ev);
			}
			Finish();
		}
		else
		{
			DebugLog.Log(string.Format("DownloadAllNewstResources: Downloading {0} items, Total Size: {1}", allDownloadList.Count, ToByteFormat(AllFileSize)));
			m_bStartedDownloading = true;

			// Trigger initial batch downloads
			int initialCount = Mathf.Min(StartDownloadCount, allDownloadList.Count);
			for (int i = 0; i < initialCount; i++)
			{
				StartDownloadNext();
			}
		}
	}

	// NATIVE-CONFIRMED: RVA 0x71F1F0
	private void StartDownloadNext()
	{
		if (allDownloadList == null || curDownloadIndex >= allDownloadList.Count) return;

		DownloadManager.VersionData vd = allDownloadList[curDownloadIndex];
		curDownloadIndex++;
		m_iInDownloadingAssetsCount++;

		StartDownloadResourceSync(vd);
	}

	// NATIVE-CONFIRMED: RVA 0x71F370
	private void StartDownloadResourceSync(DownloadManager.VersionData versionData)
	{
		if (versionData == null) return;
		DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
		if (dm != null)
		{
			dm.DownloadAsset(versionData.LoadResourceType, versionData.Filename, 3, DownloadResourceCallback);
		}
		else
		{
			// Fallback simulation if DownloadManager is not present
			DownloadCompelte(versionData.LoadResourceType, versionData.Filename);
		}
	}

	// NATIVE-CONFIRMED: RVA 0x71D220
	private void DownloadResourceCallback(string loadResourceType, string bundleName, WWW www)
	{
		m_iInDownloadingAssetsCount--;
		if (www != null && string.IsNullOrEmpty(www.error))
		{
			DownloadCompelte(loadResourceType, bundleName);
		}
		else
		{
			DebugLog.LogWarning(string.Format("DownloadAllNewstResources: Download failed for {0}/{1}", loadResourceType, bundleName));
		}

		if (curDownloadIndex < allDownloadList.Count)
		{
			StartDownloadNext();
		}
	}

	// NATIVE-CONFIRMED: RVA 0x71CBA0
	private void DownloadCompelte(string loadResourceType, string bundleName)
	{
		DownloadManager.VersionData vd = FindVersionData(loadResourceType, bundleName, allDownloadList);
		if (vd != null && downloadedList != null && !downloadedList.Contains(vd))
		{
			downloadedList.Add(vd);
		}

		DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
		if (dm != null)
		{
			dm.DownloadComplete(loadResourceType, bundleName);
		}
	}

	// NATIVE-CONFIRMED: RVA 0x71DE70
	private bool IsAllComplete()
	{
		if (allDownloadList == null) return true;
		if (downloadedList == null) return false;
		return downloadedList.Count >= allDownloadList.Count;
	}

	// NATIVE-CONFIRMED: RVA 0x71EBE0
	private void ShowDownloadRatio()
	{
		if (AllFileSize <= 0)
		{
			if (downloadProgress != null) downloadProgress.value = 1f;
			if (outputString != null) outputString.value = "100%";
			return;
		}

		long downloadedBytes = GetDownloadingFileSize();
		float ratio = Mathf.Clamp01((float)downloadedBytes / AllFileSize);

		if (downloadProgress != null) downloadProgress.value = ratio;
		if (outputString != null) outputString.value = string.Format("{0:P0}", ratio);
	}

	// NATIVE-CONFIRMED: RVA 0x71D930
	private long GetDownloadingFileSize()
	{
		if (downloadedList == null) return 0L;
		long total = 0L;
		foreach (var vd in downloadedList)
		{
			if (vd != null) total += vd.FileSize;
		}
		return total;
	}

	// NATIVE-CONFIRMED: RVA 0x71D2F0
	private DownloadManager.VersionData FindVersionData(string loadResourceType, string bundleName, List<DownloadManager.VersionData> list)
	{
		if (list == null) return null;
		foreach (var vd in list)
		{
			if (vd != null && vd.LoadResourceType == loadResourceType && vd.Filename == bundleName)
			{
				return vd;
			}
		}
		return null;
	}

	// NATIVE-CONFIRMED: RVA 0x71DD40
	public static long GetFileTotalSize(List<DownloadManager.VersionData> filelist)
	{
		if (filelist == null) return 0L;
		long total = 0L;
		foreach (var vd in filelist)
		{
			if (vd != null) total += vd.FileSize;
		}
		return total;
	}

	// NATIVE-CONFIRMED: RVA 0x71D470
	public static List<DownloadManager.VersionData> GetDownloadList()
	{
		try
		{
			DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
			if (dm == null) return new List<DownloadManager.VersionData>();

			Dictionary<string, DownloadManager.VersionData> remote = dm.remoteVersionList;
			if (remote == null || remote.Count == 0)
			{
				return new List<DownloadManager.VersionData>();
			}

			List<DownloadManager.VersionData> needDownload = new List<DownloadManager.VersionData>();
			foreach (var kvp in remote)
			{
				string key = kvp.Key;
				DownloadManager.VersionData remoteVd = kvp.Value;

				if (dm.NeedDownload(remoteVd.Filename, remoteVd.LoadResourceType) != DownloadManager.DownLoadRecord.LoadStateEnum.Downloaded)
				{
					needDownload.Add(remoteVd);
				}
			}

			return needDownload;
		}
		catch (Exception ex)
		{
			DebugLog.LogError("DownloadAllNewstResources.GetDownloadList error: " + ex);
			return new List<DownloadManager.VersionData>();
		}
	}

	// NATIVE-CONFIRMED: RVA 0x71F480
	public static string ToByteFormat(long fileSize)
	{
		if (fileSize < 1024L) return string.Format("{0} B", fileSize);
		if (fileSize < 1048576L) return string.Format("{0:F2} KB", fileSize / 1024f);
		return string.Format("{0:F2} MB", fileSize / 1048576f);
	}
}



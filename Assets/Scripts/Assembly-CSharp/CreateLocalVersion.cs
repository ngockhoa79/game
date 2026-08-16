using System;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class CreateLocalVersion : FsmStateAction
{
	[RequiredField]
	public FsmEvent E_OnSuccess;

	[RequiredField]
	public FsmEvent E_OnFail;

	// NATIVE-CONFIRMED: RVA 0x705F60
	public override void OnEnter()
	{
		DebugLog.Log("Enter CreateLocalVersion");
		CreateRecord();
		Finish();
	}

	// NATIVE-CONFIRMED: RVA 0x7057E0
	public void CreateRecord()
	{
		try
		{
			DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
			if (dm != null)
			{
				if (dm.downLoadResult == null)
				{
					dm.downLoadResult = new System.Collections.Generic.Dictionary<string, DownloadManager.DownLoadRecord>();
				}

				if (dm.remoteVersionList != null && dm.remoteVersionList.Count > 0)
				{
					foreach (var kvp in dm.remoteVersionList)
					{
						var vd = kvp.Value;
						if (vd != null)
						{
							var rec = new DownloadManager.DownLoadRecord(
								vd.LanguageVersion,
								vd.Version,
								vd.LoadResourceType,
								vd.BundleDirectory,
								vd.Filename,
								DownloadManager.DownLoadRecord.LoadStateEnum.Preloaded,
								true,
								1,
								vd.BundleList
							);
							string key = DownloadManager.GetDownloadRecordKey(vd.LoadResourceType, vd.Filename);
							dm.downLoadResult[key] = rec;
						}
					}
				}

				int lineCount = dm.downLoadResult.Count;
				DebugLog.Log("CreateLocalVersion::CreateRecord LineCount = " + lineCount);
				dm.WriteRecordFile();
			}

			var evSuccess = (E_OnSuccess != null && !string.IsNullOrEmpty(E_OnSuccess.Name)) ? E_OnSuccess : FsmEvent.GetFsmEvent("Success");
			if (Fsm != null && evSuccess != null)
			{
				Fsm.Event(evSuccess);
			}
		}
		catch (Exception ex)
		{
			DebugLog.LogError("CreateLocalVersion::CreateRecord Exception: " + ex);
			var evFail = (E_OnFail != null && !string.IsNullOrEmpty(E_OnFail.Name)) ? E_OnFail : FsmEvent.GetFsmEvent("Fail");
			if (Fsm != null && evFail != null)
			{
				Fsm.Event(evFail);
			}
		}
	}
}


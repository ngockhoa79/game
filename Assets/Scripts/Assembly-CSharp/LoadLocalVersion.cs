using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class LoadLocalVersion : FsmStateAction
{
	[RequiredField]
	public FsmEvent E_OnSuccess;

	[RequiredField]
	public FsmEvent E_OnFail;

	private bool bResult;

	// NATIVE-CONFIRMED: RVA 0x722D50
	public override void OnEnter()
	{
		DebugLog.Log("Enter LoadLocalVersion");
		Defer.getRunner().StartCoroutine(ReadRecord());
	}

	// NATIVE-CONFIRMED: RVA 0x725DA0
	private IEnumerator ReadRecord()
	{
		string localPath = UnityEngine.Application.persistentDataPath + "/downloadRecord.txt";
		DebugLog.Log("LoadLocalVersion::ReadRecord download record path : " + localPath);

		string url = "file://" + localPath;
		DebugLog.Log("LoadLocalVersion::ReadRecord: url = " + url);

		WWW www = new WWW(url);
		yield return www;

		try
		{
			DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
			if (dm == null)
			{
				DebugLog.LogError("LoadLocalVersion: DownloadManager is null!");
				bResult = false;
				Fail();
				yield break;
			}

			if (dm.downLoadResult == null)
			{
				dm.downLoadResult = new Dictionary<string, DownloadManager.DownLoadRecord>();
			}

			if (string.IsNullOrEmpty(www.error) && !string.IsNullOrEmpty(www.text))
			{
				string text = www.text;
				string[] lines = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string rawLine in lines)
				{
					string line = rawLine.Trim();
					if (!string.IsNullOrEmpty(line))
					{
						DownloadManager.DownLoadRecord rec = new DownloadManager.DownLoadRecord(line);
						if (rec != null && !string.IsNullOrEmpty(rec.Filename))
						{
							string key = DownloadManager.GetDownloadRecordKey(rec.LoadResourceType, rec.Filename);
							dm.downLoadResult[key] = rec;
						}
					}
				}
				bResult = true;
				Success();
			}
			else
			{
				// If file does not exist or WWW error, initialize empty local version and succeed
				bResult = true;
				Success();
			}
		}
		catch (Exception ex)
		{
			DebugLog.LogError("LoadLocalVersion::ReadRecord download record causes fatal error : " + ex);
			bResult = false;
			Fail();
		}
	}

	private void Fail()
	{
		var ev = (E_OnFail != null && !string.IsNullOrEmpty(E_OnFail.Name)) ? E_OnFail : FsmEvent.GetFsmEvent("Fail");
		if (Fsm != null && ev != null)
		{
			Fsm.Event(ev);
		}
		Finish();
	}

	private void Success()
	{
		var ev = (E_OnSuccess != null && !string.IsNullOrEmpty(E_OnSuccess.Name)) ? E_OnSuccess : FsmEvent.GetFsmEvent("Success");
		if (Fsm != null && ev != null)
		{
			Fsm.Event(ev);
		}
		Finish();
	}
}


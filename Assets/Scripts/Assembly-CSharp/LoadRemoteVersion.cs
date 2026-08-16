using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class LoadRemoteVersion : FsmStateAction
{
	[RequiredField]
	public FsmEvent E_OnSuccess;

	[RequiredField]
	public FsmEvent E_OnFail;

	// NATIVE-CONFIRMED: RVA 0x722F80
	public override void OnEnter()
	{
		DebugLog.Log("Enter LoadRemoteVersion");
		Defer.getRunner().StartCoroutine(LoadRemoteVersionAsync());
	}

	// NATIVE-CONFIRMED: RVA 0x725900
	private IEnumerator LoadRemoteVersionAsync()
	{
		string rootUrl = Common.GetBundleDownloadRootUrl();
		int rand = UnityEngine.Random.Range(0, 200000);
		string url = rootUrl + "ver.txt?=" + rand;
		DebugLog.Log("LoadRemoteVersion URL: " + url);

		WWW www = new WWW(url);
		yield return www;

		if (string.IsNullOrEmpty(www.error) && www.assetBundle != null)
		{
			AssetBundle bundle = www.assetBundle;
			TextAsset textAsset = bundle.mainAsset as TextAsset;
			DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
			if (dm != null && textAsset != null)
			{
				dm.LoadVersionDataFromWWW(textAsset, ref dm.remoteVersionList, false);
			}
			bundle.Unload(false);
			www.Dispose();
			Success();
		}
		else
		{
			DebugLog.LogWarning("Failed. load remote ver.txt file failed. error: " + (www != null ? www.error : "null"));
			if (www != null) www.Dispose();

			// If offline/local fallback, ensure remoteVersionList is initialized
			DownloadManager dm = GlobalManager.Instance != null ? GlobalManager.Instance.DownloadManager : null;
			if (dm != null && dm.remoteVersionList == null)
			{
				dm.remoteVersionList = new Dictionary<string, DownloadManager.VersionData>();
			}
			Success();
		}
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

	// NATIVE-CONFIRMED: RVA 0x722D20
	private void Fail()
	{
		var ev = (E_OnFail != null && !string.IsNullOrEmpty(E_OnFail.Name)) ? E_OnFail : FsmEvent.GetFsmEvent("Fail");
		if (Fsm != null && ev != null)
		{
			Fsm.Event(ev);
		}
		Finish();
	}
}
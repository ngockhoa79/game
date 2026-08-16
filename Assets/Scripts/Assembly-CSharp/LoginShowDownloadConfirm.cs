using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class LoginShowDownloadConfirm : FsmStateAction
{
	public FsmEvent OnConfirm;

	// NATIVE-CONFIRMED: RVA 0x723420
	public override void OnEnter()
	{
		DebugLog.Log("Enter LoginShowFloatingboard");

		List<DownloadManager.VersionData> downloadList = DownloadAllNewstResources.GetDownloadList();
		long totalSize = DownloadAllNewstResources.GetFileTotalSize(downloadList);

		if (downloadList == null || downloadList.Count == 0 || totalSize <= 0)
		{
			// No items to download — auto proceed
			OnConfirmCallback();
		}
		else
		{
			string sizeStr = DownloadAllNewstResources.ToByteFormat(totalSize);
			string msg = string.Format("\u60A8\u6709\u8D44\u6E90\u9700\u8981\u66F4\u65B0\uFF1A{0}", sizeStr);
			DebugLog.Log("LoginShowDownloadConfirm message: " + msg);

			FloatingBoardManager fbm = GameObject.FindObjectOfType<FloatingBoardManager>();
			if (fbm != null)
			{
				fbm.ShowMessage(msg, OnConfirmCallback, OnCancelCallback);
			}
			else
			{
				// Fallback if UI is not loaded in scene
				OnConfirmCallback();
			}
		}
	}

	// NATIVE-CONFIRMED: <OnEnter>b__1_0 (Confirm Callback)
	private void OnConfirmCallback()
	{
		var ev = (OnConfirm != null && !string.IsNullOrEmpty(OnConfirm.Name)) ? OnConfirm : FsmEvent.GetFsmEvent("Success");
		if (Fsm != null && ev != null)
		{
			Fsm.Event(ev);
		}
		Finish();
	}

	// NATIVE-CONFIRMED: <OnEnter>b__1_1 (Cancel Callback)
	private void OnCancelCallback()
	{
		var ev = FsmEvent.GetFsmEvent("Fail");
		if (Fsm != null && ev != null)
		{
			Fsm.Event(ev);
		}
		Finish();
	}
}



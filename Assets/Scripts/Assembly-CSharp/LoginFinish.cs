using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("CosLogin")]
public class LoginFinish : FsmStateAction
{
	public enum FinishType
	{
		Success = 0,
		DownloadLocalVersionFailed = 1,
		CreateVersionFailed = 2,
		LoadLocalVersionFailed = 3,
		LoadRemoteVersionFailed = 4,
		UpdateBundlesFailed = 5
	}

	[RequiredField]
	public FinishType finishType;

	public override void OnEnter()
	{
		GameObject targetGo = (Owner != null) ? Owner.gameObject : null;
		if (targetGo != null)
		{
			targetGo.SendMessage("UpdateResourcesComplete", finishType, SendMessageOptions.DontRequireReceiver);
		}
		Finish();
	}
}

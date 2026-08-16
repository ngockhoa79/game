using HutongGames.PlayMaker;

[ActionCategory("CosLogin")]
public class LoginShowLog : FsmStateAction
{
	public enum LogType
	{
		LoadingRemoteVersion = 0,
		LoadRemoteVersionFail = 1,
		DownloadingResources = 2,
		DownloadResourcesFailed = 3
	}

	[RequiredField]
	public LogType logType;

	public FsmString downloadingProgress;

	public FsmFloat progressRatio;

	public bool bLoop;

	private string _curProgress;

	// NATIVE-CONFIRMED: RVA 0x7236E0
	private string GetLog()
	{
		switch (logType)
		{
			case LogType.LoadingRemoteVersion:
				return "\u6B63\u5728\u8BFB\u53D6\u6700\u65B0\u7684\u8D44\u6E90\u4FE1\u606F\u2026\u2026";
			case LogType.LoadRemoteVersionFail:
				return "\u8BFB\u53D6\u6700\u65B0\u7684\u8D44\u6E90\u4FE1\u606F\u5931\u8D25\uFF01";
			case LogType.DownloadingResources:
				string prog = (downloadingProgress != null) ? downloadingProgress.value : "";
				return string.Format("\u6B63\u5728\u4E0B\u8F7D\u6700\u65B0\u7684\u8D44\u6E90\u4FE1\u606F\u2026\u2026\n\u5DF2\u5B8C\u6210{0}", prog);
			case LogType.DownloadResourcesFailed:
				return "\u4E0B\u8F7D\u6700\u65B0\u7684\u8D44\u6E90\u4FE1\u606F\u5931\u8D25\uFF01";
			default:
				return string.Empty;
		}
	}

	// NATIVE-CONFIRMED: RVA 0x723850
	public override void OnEnter()
	{
		DebugLog.Log($"LoginShowLog.OnEnter logType={logType}");
		OnUpdate();
		if (!bLoop)
		{
			Finish();
		}
	}

	// NATIVE-CONFIRMED: RVA 0x7238F0
	public override void OnUpdate()
	{
		string logText = GetLog();
		if (_curProgress != logText)
		{
			_curProgress = logText;
			DebugLog.Log($"[LoginShowLog] {_curProgress}");

			UnityEngine.Debug.Log($"[LoginShowLog] {_curProgress}");
		}
	}
}

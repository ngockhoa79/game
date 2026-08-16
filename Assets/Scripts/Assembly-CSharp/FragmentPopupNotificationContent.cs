using System;
using Ice.ProjectCos.Protocol;

public class FragmentPopupNotificationContent : MyPlayerSummaryInfo
{
	public int skillfragmentId;

	public DateTime time;

	public bool bNeedSupport;

	public int Index;

	public PlayerSummaryInfoProto TargetSummary;

	public RobberyNoticeInfoListProto.TypeEnum TypeEnum;
}

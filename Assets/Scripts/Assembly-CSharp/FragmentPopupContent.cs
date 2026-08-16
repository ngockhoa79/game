using System;
using Ice.ProjectCos.Protocol;

public class FragmentPopupContent : MyPlayerSummaryInfo
{
	public bool bWin;

	public int RobbedFragmentId;

	public DateTime RobTime;

	public int ReportId;

	public RobberyReportInfoListProto.StatusCode Status;

	public RobberyReportInfoListProto.TypeEnum RobReportType;

	public void CheckWinState()
	{
	}
}

using Ice.ProjectCos.Protocol;

public class MakyouPlayoffsReportItemData
{
	public int ReportIndex { get; protected set; }

	public CrossPersonPlayOffBattleReportProto.ReportItemProto ReportData { get; protected set; }

	public MakyouPlayoffsReportItemData(int index, CrossPersonPlayOffBattleReportProto.ReportItemProto data)
	{
	}
}

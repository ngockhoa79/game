using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMakyouPlayoffsReportPanel : IceUIBase
{
	[SerializeField]
	private UIEventListener closeButton;

	public UIMakyouPlayoffsReportList ReportList;

	public UITable Table;

	public int ReportComparer(CrossPersonPlayOffBattleReportProto.ReportItemProto reportA, CrossPersonPlayOffBattleReportProto.ReportItemProto reportB)
	{
		return 0;
	}

	public void SetDetail(List<CrossPersonPlayOffBattleReportProto.ReportItemProto> reports)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void onClose(GameObject btn)
	{
	}
}

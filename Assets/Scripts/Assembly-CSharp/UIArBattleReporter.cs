using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIArBattleReporter : IceUIBase
{
	[SerializeField]
	private UIEventListener closeBtn;

	public UIArBRList BattleReportList;

	public UITable Table;

	public void SetDetail(List<RankingBattleReportProto.ReportItemProto> reports)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void close(GameObject btn)
	{
	}
}

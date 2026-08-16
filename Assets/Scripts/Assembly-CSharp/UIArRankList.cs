using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIArRankList : IceUIBase
{
	[SerializeField]
	private UIEventListener closeBtn;

	public UIArRLList RankListContainer;

	public UITable Table;

	public void SetDetail(List<PlayerSummaryInfoProto> rankSequences)
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

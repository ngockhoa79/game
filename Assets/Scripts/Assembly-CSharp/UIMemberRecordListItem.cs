using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMemberRecordListItem : IceUIBase
{
	[SerializeField]
	private UILabel rankLabel;

	[SerializeField]
	private UILabel nameLabel;

	[SerializeField]
	private UILabel killLabel;

	[SerializeField]
	private UILabel lostLabel;

	private CrossGuildPlayerRankingProto.RankingItemProto data;

	public void SetData(CrossGuildPlayerRankingProto.RankingItemProto data)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}
}

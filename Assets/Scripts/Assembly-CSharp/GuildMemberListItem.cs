using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GuildMemberListItem : IceUIBase
{
	[SerializeField]
	private UILabel rankLabel;

	[SerializeField]
	private UILabel nameLabel;

	[SerializeField]
	private UILabel killLabel;

	[SerializeField]
	private UILabel lostLabel;

	public Transform[] icons;

	private List<UniIcon> iconList;

	private CrossGuildBattleResultProto.RakingItemProto data;

	public void SetData(CrossGuildBattleResultStruct proto)
	{
	}

	private void AddIcon(ThingHolding h, Transform parent)
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

	protected override void DoDestroy()
	{
	}
}

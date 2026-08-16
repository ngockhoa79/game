using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIGuildRewardListItem : IceUIBase
{
	private CrossGuildSeasonRankBonusTemplate data;

	[SerializeField]
	private UIGrid ugrid;

	[SerializeField]
	private UILabel rankLabel;

	[SerializeField]
	private Transform labelPos;

	public UILabel[] labels;

	private List<UniIcon> iconList;

	public void SetData(CrossGuildSeasonRankBonusTemplate data)
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

	protected void addUIListByData()
	{
	}

	private void rePosition()
	{
	}

	private void clearGrid()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoDestroy()
	{
	}
}

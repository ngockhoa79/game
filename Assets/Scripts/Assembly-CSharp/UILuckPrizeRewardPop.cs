using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILuckPrizeRewardPop : IceUIBase
{
	[SerializeField]
	private UIEventListener btnOk;

	[SerializeField]
	private UIGrid uigride;

	[SerializeField]
	private UILabel lbtip;

	private GoddessGrailInfoProto.ConfigProto protoInfo;

	private GoddessGrailInfoProto info;

	private bool enableReward;

	public Action RewardBack;

	public bool EnableReward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetData(GoddessGrailInfoProto.ConfigProto data, GoddessGrailInfoProto idata)
	{
	}

	protected override void DoInit()
	{
	}

	public List<ThingHolding> GetRewardList(GoddessGrailInfoProto.ConfigProto protoInfo)
	{
		return null;
	}

	private void updateView()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void onClick(GameObject obj)
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoDestroy()
	{
	}

	protected void SetDataMerge(List<ThingHolding> mergedList)
	{
	}

	protected void ClearIcons()
	{
	}

	protected void ChangeDepth(int depth)
	{
	}

	protected void AddIcon(ThingHolding h)
	{
	}

	private List<ThingHolding> mergeList(List<ThingHolding> thingList)
	{
		return null;
	}
}

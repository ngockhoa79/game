using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class PopupItem : IceUIBase
{
	public UIButton bnOK;

	public UIEventListener eventOk;

	public GameObject goItemList;

	public UIGrid gridList;

	public IceAnimatorTotalCommander animation_in;

	public IceAnimatorTotalCommander animation_out;

	private bool mNeedShowCard;

	public GameObject RedPackRoot;

	public UILabel lbCount;

	public GameObject goFullPackageTips;

	public Action E_OnOK;

	public Action<UniIcon> E_OnIconClick;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
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

	protected override void DoDispose()
	{
	}

	public void SetByMail(MailItemInfo data)
	{
	}

	public void SetData(List<ThingHolding> thingList, int redPack = -1, bool isFullpackage = false)
	{
	}

	public void SetDataWithoutMerge(List<ThingHolding> mergedList, bool showCardAward = false)
	{
	}

	public void ClearIcons()
	{
	}

	public void ChangeDepth(int depth)
	{
	}

	public void AddIcon(ThingHolding h)
	{
	}

	private static List<ThingHolding> mergeList(List<ThingHolding> thingList)
	{
		return null;
	}
}

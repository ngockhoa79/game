using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UISweepResult : IceUIBase
{
	public UILabel LblGold;

	public UILabel LblExp;

	public UIEventListener OnOK;

	public GameObject goItemList;

	public UIGrid gridList;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	private GameObject popupObj;

	private UIPVEDropTips popupUI;

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetData(List<ThingHolding> thingList, int gold, int exp)
	{
	}

	public void ClearIcons()
	{
	}

	public void ChangeDepth(int depth)
	{
	}

	public void AddUniIcon(ThingHolding th)
	{
	}

	private void SpawnDropTips(string name, string config, string desc)
	{
	}

	private void OnDropTipsClosed()
	{
	}
}

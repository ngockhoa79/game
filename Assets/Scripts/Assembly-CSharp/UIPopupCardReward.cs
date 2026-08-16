using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPopupCardReward : IceUIBase
{
	public Action E_OnConfirm;

	[SerializeField]
	private GameObject[] Holders;

	[SerializeField]
	private UIEventListener btnStart;

	[SerializeField]
	private UIEventListener btnConfirm;

	[SerializeField]
	private float intervalTime;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	private List<UIPopupCard> contents;

	private int count;

	public void SetData(List<ThingHolding> data)
	{
	}

	private void clear()
	{
	}

	private void StartPlayAnimation()
	{
	}
}

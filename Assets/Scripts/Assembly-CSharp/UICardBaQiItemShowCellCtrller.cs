using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiItemShowCellCtrller : IceUIBase
{
	[SerializeField]
	private IceAnimatorTotalCommander enterAnim;

	[SerializeField]
	private IceAnimatorTotalCommander exitAnim;

	[SerializeField]
	private UILabel level;

	[SerializeField]
	private UICardBaQiShowItemWrapCtrller[] items;

	[HideInInspector]
	public CardShowItemStruct data;

	private float startX;

	private float startY;

	protected override void DoInit()
	{
	}

	protected override void DoClearData()
	{
	}

	public void setData(CardShowItemStruct data)
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

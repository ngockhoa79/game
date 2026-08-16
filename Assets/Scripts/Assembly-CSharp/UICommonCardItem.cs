using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICommonCardItem : UICommonItem
{
	public UICardHalfBodyPortrait CardPortrait;

	public UILabel CardLevelNumber;

	public UILabel CardPrice;

	public GameObject goNewNotice;

	[SerializeField]
	private UILabel CardID;

	[SerializeField]
	private GameObject OnField;

	[SerializeField]
	private GameObject StarupEnable;

	[SerializeField]
	private UILabel WakeupLabel;

	[SerializeField]
	protected GameObject ExpGroup;

	[SerializeField]
	private UILabel lblExp;

	[SerializeField]
	private BaQiIcon baqiIcon;

	public Hero hero { get; private set; }

	public override void SetData(ItemHolding item, EState state = EState.Idle, EMode mode = EMode.NormalMode)
	{
	}

	private void setData(Hero hero)
	{
	}

	public void ShowExp()
	{
	}

	public void SetNotifyRoddot()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}
}

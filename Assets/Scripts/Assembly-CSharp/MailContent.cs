using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class MailContent : IceUIBase
{
	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	public UIEventListener eventClose;

	public UIButton bnViewBattle;

	public UIButton bnGetReward;

	public GameObject goRewardGot;

	public UILabel lbTitle;

	public UILabel lbContent;

	public UILabel lbReceiver;

	public Action<MailItemInfo> OnViewBattle;

	public Action<MailItemInfo> OnGetReward;

	public GameObject goItemList;

	public UIGrid gridList;

	public UIScrollView svContent;

	public BoxCollider bcTouchArea;

	public UIPanel ClipPanel;

	public UISprite spBG;

	public GameObject btnRoot;

	private MailItemInfo mData;

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

	private void Start()
	{
	}

	public void SetData(MailItemInfo info)
	{
	}

	public void setButton()
	{
	}

	public void OnViewBattleClick()
	{
	}

	public void OnGetRewardClick()
	{
	}

	private void addRewardIcons()
	{
	}

	private void addItem(ItemHolding h)
	{
	}

	private void addValue(PropertyHolding ph)
	{
	}

	private void addUniIcon(ThingHolding th)
	{
	}

	private void reposionControls()
	{
	}
}

using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemMail : IceUIBase
{
	public delegate void MailItemDelegate(MailItemInfo info, ItemMail uiItem);

	public UIButton bnViewBattle;

	public UIButton bnGetReward;

	public GameObject goRewardGot;

	public UILabel lbTitle;

	public UILabel lbSender;

	public UILabel lbDate;

	public UISprite spUnRead;

	public UISprite spRead;

	public UISprite spAttach;

	public UISprite spHeaderUnRead;

	public UISprite spHeaderRead;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	public MailItemDelegate OnViewBattle;

	public MailItemDelegate OnViewDetail;

	public MailItemDelegate OnGetReward;

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

	public void SetData(MailItemInfo info)
	{
	}

	private void setMailIcon()
	{
	}

	public void setButton()
	{
	}

	public void OnViewBattleClick()
	{
	}

	public void OnViewDetailClick()
	{
	}

	public void OnGetRewardClick()
	{
	}
}

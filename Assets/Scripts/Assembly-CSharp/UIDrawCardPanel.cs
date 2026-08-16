using System;
using UnityEngine;

public class UIDrawCardPanel : IceUIBase
{
	public UILabel lbCountGem;

	public UILabel lbCountFriendPoint;

	public UILabel lbCostFriend;

	public UILabel lbCostGold;

	public UILabel lbCostGold10;

	public UpdateTimerUTC CDTimerGold;

	public UpdateTimerUTC CDTimerFriend;

	public UIEventListener eventDrawFriend;

	public UIEventListener eventDraw;

	public UIEventListener eventDraw10;

	public UIEventListener eventSlotDrawFriend;

	public UIEventListener eventSlotDrawGlod;

	public UIEventListener AddDrawCard;

	public GameObject FirstDrawTag;

	public GameObject FirstDraw10Tag;

	public GameObject FirstDraw10Tag_Static;

	public GameObject Draw10Tag;

	[HideInInspector]
	public UICardShopFrame OutFrame;

	public IceAnimatorTotalCommander AnimateLeft;

	public IceAnimatorTotalCommander AnimateRight;

	public IceAnimatorTotalCommander AnimateTube;

	public IceAnimatorTotalCommander AnimateFirstDraw10;

	public IceAnimatorTotalCommander AnimateFirstDraw10_Once;

	public float AnimateEndTime;

	public UITexture NPC;

	public void ActivateEmbeddedNPC(bool active)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void setTitle(int value = 0)
	{
	}

	private void showFirstDrawCardTag()
	{
	}

	public string OnGetDateString(TimeSpan d)
	{
		return null;
	}

	private void beginCDGold()
	{
	}

	private void beginCDFriend()
	{
	}

	private void OnDrawCardFailed()
	{
	}

	private void gotoDrawCardByFriend()
	{
	}

	private void gotoDrawCardByDiamond()
	{
	}

	private void gotoDrawCardByDiamond10()
	{
	}

	private void showDrawCardDialog()
	{
	}

	public void PlayAnimateLeft()
	{
	}

	public void PlayAnimateRight()
	{
	}

	public void AnimateReset()
	{
	}

	public void BeginTubeAnimation()
	{
	}
}

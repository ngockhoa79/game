using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFriendGiftPanel : IceUIBase, IceUIReusableList<Friend>.IVisualizer
{
	public UILabel lbTodayRestFeedCount;

	public GameObject timerRoot;

	public UpdateTimerUTC CDTimer;

	public UISprite spKey;

	public UILabel lbPrizeProgress;

	public UIProgressBarCtrller EggProgressBar;

	public GameObject goEggFull;

	public UIButton bnEgg;

	public UIFriendListAnimator FriendInfoList;

	public UIEventListener E_help;

	public GameObject goHint;

	public UIGrid gdFriendAddEggPos;

	public IceAnimatorTotalCommander AnimationEggFull;

	public UIPanel ClipPanel;

	private Vector2 mClipOffset;

	private Vector4 mClipRegion;

	private Vector3 mClipPos;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, Friend data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void SetList()
	{
	}

	private void setAddEggList()
	{
	}

	public void SetTitle()
	{
	}

	private void beginEggCDTimer()
	{
	}

	private void Update()
	{
	}

	public void ShowReward(GameObject go)
	{
	}

	public void OnEggInfoChanged()
	{
	}

	public void SendFriendGift(Friend f, ItemFriendGift uiItem)
	{
	}

	private void sendGiftToFriend(Friend f, ItemFriendGift uiItem)
	{
	}

	public void GetMyReward(Friend f, ItemFriendGift uiItem)
	{
	}

	public void OnItemClick(Friend f, ItemFriendGift uiItem)
	{
	}

	public void OnEggClick()
	{
	}

	public void ResetPanel()
	{
	}

	private void storePanel()
	{
	}
}

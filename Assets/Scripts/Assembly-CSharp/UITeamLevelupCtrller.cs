using System;
using UnityEngine;

public class UITeamLevelupCtrller : IceUIBase
{
	public UILabel item_level;

	public UITeamLevelupInfoItemCtrller item_currentSta;

	public UITeamLevelupInfoItemCtrller item_fightCards;

	public UITeamLevelupInfoItemCtrller item_maxFriend;

	public UITeamLevelupInfoItemCtrller item_maxEquipmentLv;

	public UITeamLevelupInfoItemCtrller item_maxCardLv;

	public GameObject newFunctionObject;

	public UIEventListener closeButton;

	public IceAnimatorTotalCommander ContentAnimation;

	public GameObject Line5Anim;

	public GameObject Line4Anim;

	public GameObject BlockObject;

	public IceAnimatorTotalCommander NewFunAnimation;

	private const float NEWF_OPEN_TIME = 1.6f;

	private int beforeLv;

	private int afterLv;

	private int newFunction;

	private bool newFunShown;

	private float newFunTimer;

	private bool battleMode;

	public static Action OnConfirmInUIScene;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void Update()
	{
	}

	public void SetLevelupData(int _beforeLv, int _afterLv)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void ClosePanel(GameObject _go)
	{
	}

	public void SetBattleCloseBtn(UIEventListener.VoidDelegate _callBack)
	{
	}

	private void DestoryPanel(GameObject _go)
	{
	}

	public void HideNewFunction()
	{
	}

	private void SetInfo()
	{
	}

	private void CheckNewFunctionOpen()
	{
	}

	private void PlayNewFunction()
	{
	}
}

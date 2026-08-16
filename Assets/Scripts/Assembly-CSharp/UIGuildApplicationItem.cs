using System;
using UnityEngine;

public class UIGuildApplicationItem : IceUIBase
{
	public UILabel lbLevel;

	public UILabel lbName;

	public UILabel lbTotalBattleValue;

	public UILabel lbLastTime;

	public UIAeCardDisplayer CardDisplay;

	public UIEventListener ButtonConfirm;

	public UIEventListener ButtonRefuse;

	public GameObject ButtonsGroup;

	public GameObject AlreadyConfirmGroup;

	public GameObject AlreadyRefuseGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	private GuildApplicationData ApplicantData;

	protected override void DoInit()
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

	public void Clear()
	{
	}

	public void SetData(GuildApplicationData itemData)
	{
	}

	public void SetState(GuildApplicationData.ApplicationItemState state)
	{
	}

	public void OnConfirmClick(GameObject go)
	{
	}

	public void OnRefuseClick(GameObject go)
	{
	}
}

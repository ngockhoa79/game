using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIConvoySelfInfo : UIConvoyPopupBase
{
	public UIAeCardDisplayer PlayerDisplayer;

	public UILabel LblPlayerName;

	public UILabel LblPlayerLv;

	public UILabel LblPlayerCar;

	public UILabel LblGuardName;

	public UILabel LblGuardLv;

	public UILabel LblPlayerPower;

	public UILabel LblRemainValue;

	public UILabel LblExtraValue;

	public UISprite ImgCoin2;

	public UISprite GuardLvIcon;

	public UILabel LbGuildName;

	public UISprite ExtraGainDesc;

	public UIEventListener OKButton;

	public Action OnClose;

	private EscortLobbyData data;

	protected override void SetID()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(EscortLobbyData data)
	{
	}

	public void Update()
	{
	}

	private void OnOKClicked(GameObject buttonClicked)
	{
	}

	public override void ClosePanel()
	{
	}
}

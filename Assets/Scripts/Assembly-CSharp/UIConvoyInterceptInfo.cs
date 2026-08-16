using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIConvoyInterceptInfo : UIConvoyPopupBase
{
	public UIAeCardDisplayer PlayerDisplayer;

	public UILabel LblPlayerName;

	public UILabel LblPlayerLv;

	public UILabel LblPlayerCar;

	public UILabel LblGuardName;

	public UILabel LblGuardLv;

	public UILabel LblPlayerPower;

	public UILabel LblRemainValue;

	public UILabel LblLoseValue;

	public UISprite GuardLvIcon;

	public UILabel LbGuildName;

	public UIEventListener InterceptButton;

	public UIEventListener CancelButton;

	public UIEventListener DetailButton;

	public Action<Friend> OnViewPlayerDetail;

	public Action<EscortLobbyData> OnIntercept;

	public Action OnClose;

	public Friend playerToBeViewed;

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

	private void OnInterceptClicked(GameObject obj)
	{
	}

	private void OnCancelClicked(GameObject buttonClicked)
	{
	}

	public override void ClosePanel()
	{
	}
}

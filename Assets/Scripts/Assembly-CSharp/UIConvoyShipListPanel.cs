using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIConvoyShipListPanel : UIConvoyPopupBase
{
	public UIEventListener CloseButton;

	public UIConvoyShipList ShipList;

	public UITable Table;

	public Action<EscortLobbyData> E_ShipSelected;

	protected override void SetID()
	{
	}

	public void SetDetail(List<EscortLobbyData> ships)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void OnClose(GameObject btn)
	{
	}

	public override void ClosePanel()
	{
	}

	public void OnShipSelected(EscortLobbyData shipData)
	{
	}
}

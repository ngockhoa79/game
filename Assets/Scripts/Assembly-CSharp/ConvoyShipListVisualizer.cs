using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ConvoyShipListVisualizer : IceUIReusableList<EscortLobbyData>.IVisualizer
{
	public Action<EscortLobbyData> E_ShipSelected;

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, EscortLobbyData data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void OnShipItemSelected(EscortLobbyData shipData)
	{
	}
}

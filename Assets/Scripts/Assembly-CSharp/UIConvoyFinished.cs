using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIConvoyFinished : UIConvoyPopupBase
{
	public UIEventListener ButtonOK;

	public UIEventListener ButtonRecord;

	public UIGrid ItemsGrid;

	public UILabel CoinValue;

	public UILabel ExpValue;

	public Action E_PanelClose;

	private List<EscortWrestRecordProto> lootRecords;

	protected override void SetID()
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

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(List<ThingHolding> itemList, int coinNum, int expNum, List<EscortWrestRecordProto> records)
	{
	}

	public void ClearIcons()
	{
	}

	public void AddIcon(ThingHolding h)
	{
	}

	public void OnClose(GameObject clickedButton)
	{
	}

	public void ShowRecord(GameObject clickedButton)
	{
	}

	public override void ClosePanel()
	{
	}
}

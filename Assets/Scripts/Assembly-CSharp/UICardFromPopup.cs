using System;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;
using UnityEngine;

public class UICardFromPopup : IceUIBase, IceUIReusableList<Navigator>.IVisualizer
{
	public UISprite spYouHave;

	public UISprite spFragCount;

	public UITable table;

	public DropLevelListAnimator LevelList;

	public UILabel lbCardName;

	public UILabel lbCardDesc;

	public UILabel lbCount;

	public UIEventListener BtnClose;

	public UIEventListener eventSell;

	public Action E_OnClose;

	public Action E_OnSell;

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, Navigator n)
	{
	}

	public void ClearData(GameObject widget)
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

	public void SetItem(AbstractItem Item)
	{
	}

	public void OnGotoLevel(Navigator n, PVELevel level)
	{
	}

	public void OnGotoUI(Navigator n)
	{
	}

	private void clear()
	{
	}

	private void handleClose()
	{
	}
}

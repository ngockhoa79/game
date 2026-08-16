using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIDialogYesNoRefreshShop : MonoBehaviour
{
	public PayTypeIcon PayIcon;

	public UILabel lbText1;

	public UILabel lbText2;

	public UILabel lbRestRefresh;

	public UILabel lbTextMoney;

	public UIEventListener eventRefresh;

	public UIEventListener eventCancel;

	public Action E_Refresh;

	public Action E_Cancel;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetForShopRefresh(Shop shopList)
	{
	}
}

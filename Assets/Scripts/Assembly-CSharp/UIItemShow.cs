using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIItemShow : MonoBehaviour
{
	public GameObject ItemPos;

	public GameObject BtnGroupSingle;

	public GameObject BtnGroupTwo;

	public UIButton bnAgain;

	public UIButton bnAgain10;

	public UILabel lbItemName;

	public UIEventListener eventOK1;

	public UIEventListener eventOK2;

	public UIEventListener eventAgain;

	public UIEventListener eventAgain10;

	public Action OnOK;

	public Action OnAgain;

	private GameObject mItemObj;

	private ItemHolding mItem;

	public UniIcon ItemIcon;

	public UILabel lbCostFriend;

	public void Clear()
	{
	}

	public void LoadItem(ItemHolding itemH)
	{
	}

	public void UnloadItem()
	{
	}

	public void SetButtonModel(bool IsTryAgainShow, bool isDraw10Time)
	{
	}

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}
}

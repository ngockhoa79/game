using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemCharge : MonoBehaviour
{
	public UILabel lbPrice;

	public UILabel lbExtraValue;

	public UILabel lbExtraText;

	public GameObject ShowRoot;

	public GameObject TagFirstBuy;

	public GameObject TagTuiJian;

	public GameObject ExtraPart;

	public UITexture txCharge;

	public UIEventListener eventBuy;

	public Action<ChargeInfo> E_OnBuy;

	private ChargeInfo mData;

	[HideInInspector]
	public UIDragScrollView Dragger;

	private void Start()
	{
	}

	public void Clear()
	{
	}

	public void SetData(ChargeInfo data)
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}
}

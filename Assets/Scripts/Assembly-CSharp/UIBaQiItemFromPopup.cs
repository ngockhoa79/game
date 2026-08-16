using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIBaQiItemFromPopup : UIItemFromPopup
{
	private GameObject baqiItemProps;

	[HideInInspector]
	public bool IsShowBtn;

	[HideInInspector]
	public CardBaQiItem item;

	private int leftPosX;

	private int centerPosX;

	private int rightPosX;

	private bool canExchange;

	private bool canEquip;

	protected override void DoPrepare()
	{
	}

	public override void OnActionTake()
	{
	}

	private void OnGearForgeResponse(bool success, object response)
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void setInfo()
	{
	}

	protected override void setActionButtonMode()
	{
	}

	protected void changeEquipBtnSkin(int type = 1)
	{
	}

	protected void updateBtnPos(int type)
	{
	}
}

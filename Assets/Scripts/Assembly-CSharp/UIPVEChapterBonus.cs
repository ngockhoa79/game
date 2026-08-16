using System;
using UnityEngine;

public class UIPVEChapterBonus : IceUIBase
{
	[SerializeField]
	private UniIcon DropItem;

	[SerializeField]
	private UILabel StarNumber;

	[SerializeField]
	private UIEventListener OnClick;

	[SerializeField]
	private GameObject ActiveEffect;

	[SerializeField]
	private GameObject ImgPicked;

	[SerializeField]
	private UIWidget widget;

	private bool ActiveFlag;

	private bool IsLock;

	private int chapterId;

	private bool isShowItem;

	private int DropType;

	private int DropId;

	private int DropCount;

	private GameObject PopupObj;

	private UIPVEBonusPopup Popup;

	public Action E_OnChange;

	public void SetData(int chapterId)
	{
	}

	private void ShowHolding(int type, int id, int count)
	{
	}

	private void OnClicked(GameObject obj)
	{
	}

	private void OnNotify()
	{
	}

	private void OnPopupEntered()
	{
	}

	private void OnPopupClosed()
	{
	}
}

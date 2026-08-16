using System;
using UnityEngine;

public class UIPopupSkillBagFull : IceUIBase
{
	public UILabel lbTitle;

	public UILabel lbContent;

	public UILabel lbCount;

	public UIEventListener EnlargeButton;

	public UIEventListener SkillUpgradeButton;

	public UIEventListener DissolveButton;

	public UIEventListener SellButton;

	public UIEventListener CloseButton;

	private GameObject popupObj;

	private UIPopupAddCardBagSlot addSlotPopup;

	public void SetData()
	{
	}

	private void ClosePopup(Action callback)
	{
	}

	private void OnAddSlotPopup()
	{
	}
}

using System;
using UnityEngine;

public class UIPopupCardBagFull : IceUIBase
{
	public UILabel lbContent;

	public UILabel lbTitle;

	public UILabel lbCount;

	public UIEventListener EnlargeButton;

	public UIEventListener AssimilateButton;

	public UIEventListener DissolveButton;

	public UIEventListener SellButton;

	public UIEventListener CloseButton;

	private GameObject popupObj;

	private UIPopupAddCardBagSlot addSlotPopup;

	public void SetData()
	{
		gameObject.SetActive(true);
		if (CloseButton != null)
		{
			CloseButton.onClick = (go) => { ClosePopup(null); };
		}
	}

	private void ClosePopup(Action callback)
	{
		gameObject.SetActive(false);
		if (callback != null) callback();
	}

	private void OnAddSlotPopup()
	{
		if (addSlotPopup != null) addSlotPopup.SetData();
	}
}

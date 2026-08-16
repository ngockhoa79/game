using System;

public class UIPopupGearBagFull : IceUIBase
{
	public UILabel lbTitle;

	public UILabel lbContent;

	public UILabel lbCount;

	public UIEventListener EnlargeButton;

	public UIEventListener DissolveButton;

	public UIEventListener SellButton;

	public UIEventListener CloseButton;

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
	}
}

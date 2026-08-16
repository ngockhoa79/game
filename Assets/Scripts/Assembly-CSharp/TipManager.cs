using UnityEngine;

public class TipManager
{
	private UITipsPopup mTip;

	private string mText;

	private bool mIsTipEnable;

	public UITipsPopup CurrentTip => null;

	public bool TipEnabe
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UITipsPopup PopupTip(Transform parent, string text, float offsetX = 0f, float offsetY = 0f)
	{
		return null;
	}

	public UITipsPopup PopupTip(TipData data)
	{
		return null;
	}

	public void CloseTip()
	{
	}
}

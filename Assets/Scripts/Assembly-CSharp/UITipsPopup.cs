using UnityEngine;

public class UITipsPopup : MonoBehaviour
{
	public UILabel lbTip;

	public UISprite spBG;

	public GameObject Pos;

	public BoxCollider boxArea;

	public UIEventListener eventTip;

	public const float MinWidth = 50f;

	public const float MinHeight = 30f;

	public const int PaddingX = 20;

	public const int PaddingY = 20;

	private Aligment mAgn;

	private void Start()
	{
	}

	public void SetTipAnchor(Aligment ali)
	{
	}

	public void SetFontSize(int fontSize)
	{
	}

	public void SetTipText(string text, int maxCharPerLine)
	{
	}

	private void autoSize()
	{
	}

	private void setAnchorPosByAligment()
	{
	}

	private void adjstPos()
	{
	}
}

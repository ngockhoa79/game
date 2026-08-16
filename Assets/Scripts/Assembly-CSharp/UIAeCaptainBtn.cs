using System;
using UnityEngine;

public class UIAeCaptainBtn : MonoBehaviour
{
	private const string GenericRightAlignedBlue = "GenericRightAlignedBlue";

	private const string GenericRightAlignedDisable = "GenericRightAlignedBlueDisable";

	private const string SetAsLeaderTxt = "ArrayTxtSetAsLeader";

	private const string SetAsLeaderGrayTxt = "ArrayTxtSetAsLeaderGray";

	private const string Background = "Background";

	private const string Text = "Text";

	[SerializeField]
	private UIEventListener listener;

	[SerializeField]
	private UIButton button;

	[SerializeField]
	private UISprite background;

	[SerializeField]
	private UISprite text;

	public void SetBtn(Action onClick)
	{
	}
}

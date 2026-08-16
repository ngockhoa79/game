using System;
using UnityEngine;

public class UIArRedPackDeliveryBtn : MonoBehaviour
{
	public const string TxtInnate = "UIPvPRPTxtSend";

	public const string TxtCrystal = "UIPvPRPBtnSendUsingCrystal";

	public const string TxtDisable = "UIPvPRPTxtSendGray";

	public const string TxtDeliveried = "";

	public const string BtnInnate = "UIPVPBtnRefresh";

	public const string BtnCrystal = "UIPVPBtnRefresh";

	public const string BtnDisable = "GenericRightAlignedBlueDisable";

	public const string BtnDeliveried = "UIPvPRPBtnRunning";

	public UIEventListener DeliveryBtn;

	public UISprite Btn;

	public UISprite BtnTxt;

	public UISprite LastTitle;

	public UISprite RunningSlot;

	public UISprite OutofBoundary;

	public UILabel LastRank;

	public UILabel RunningCount;

	private Vector2 Narrow;

	private Vector2 Deliveried;

	public void Set(UIArRedPackDisplayer.Mode m, int lastRank, int sent, int total, Action clicked)
	{
	}
}

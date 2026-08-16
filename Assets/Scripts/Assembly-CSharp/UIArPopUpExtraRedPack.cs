using System;

public class UIArPopUpExtraRedPack : IceUIBase
{
	public bool ActiveSpine;

	private const string TipKey = "red_packet_tips_2";

	private int CrystalIconGap;

	private Action onConfirm;

	public UIEventListener ConfirmBtn;

	public UIEventListener CancelBtn;

	public UILabel Content;

	protected override void DoInit()
	{
	}

	public void SetDetail(int crystal, Action onConfirm)
	{
	}

	private string createGap()
	{
		return null;
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}

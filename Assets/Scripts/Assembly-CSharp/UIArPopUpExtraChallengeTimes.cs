using System;

public class UIArPopUpExtraChallengeTimes : IceUIBase
{
	private int CrystalIconGap;

	private Action onConfirm;

	public UIEventListener ConfirmBtn;

	public UIEventListener CancelBtn;

	public UILabel Content;

	public UILabel Tip;

	protected override void DoInit()
	{
	}

	public void SetDetail(int crystal, int remain, int total, Action onConfirm)
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

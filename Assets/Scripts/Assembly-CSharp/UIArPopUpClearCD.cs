using System;

public class UIArPopUpClearCD : IceUIBase
{
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

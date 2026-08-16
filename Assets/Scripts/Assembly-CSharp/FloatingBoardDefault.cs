using System;

public class FloatingBoardDefault : IceUIBase
{
	public enum PanelType
	{
		OKCancel = 0,
		Confirm = 1
	}

	public UILabel lbContent;

	public UILabel lbTag;

	public UICustomLabel customLabel;

	public UIEventListener btnOK;

	public UIEventListener btnCancel;

	public UIEventListener btnConfirm;

	public UIEventListener btnClose;

	public UIFloatingBoardFrame frame;

	public UISprite txtConfirm;

	public UISprite txtCharge;

	private string m_tag;

	private string m_content;

	private Action E_OnOk;

	private Action E_OnCancel;

	private Action E_OnConfirm;

	private Action E_OnClose;

	private PanelType panelType;

	private bool bOpen;

	protected override void DoPrepare()
	{
	}

	public void SetDataConfirm(string m_tag, string content, Action onConfirm, Action onClose, bool bContainCollider)
	{
	}

	public void SetDataOkCancel(string tag, string content, Action onOK, Action onCancel, Action onClose, bool bContainCollider)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void ShowPanelData()
	{
	}

	private void ShowLabel(string content)
	{
	}

	private void ShowBtnCharge(bool bShow)
	{
	}
}

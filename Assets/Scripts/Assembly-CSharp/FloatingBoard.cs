using UnityEngine;

public class FloatingBoard : MonoBehaviour
{
	public delegate void H_ButtonClicked(FloatingButtonEnum buttonClick);

	public enum FloatingButtonEnum
	{
		OnConfirm = 0,
		OnOk = 1,
		OnCancel = 2,
		OnClose = 3
	}

	public GameObject ConfirmButton;

	public GameObject OkButton;

	public GameObject CancelButton;

	public GameObject CloseButton;

	public UILabel Title;

	public UILabel Content;

	public GameObject RootPanel;

	public GameObject blockRoot;

	public UILabel blockLbTitle;

	public UILabel blockLbMessage;

	private UISweepMenu uiSweepMenu;

	private UILabel bConfirmButtonLabel;

	private UILabel bOKButtonLabel;

	private UILabel bCancelButtonLabel;

	private UIEventListener btnConfirmEvent;

	private UIEventListener btnOkEvent;

	private UIEventListener btnCancelEvent;

	private UIEventListener btnCloseEvent;

	public H_ButtonClicked E_OnButtonClicked;

	private bool _openState;

	public Animation _anim;

	public bool OpenState => false;

	public void ShowBlock(string title, string message)
	{
	}

	public void CloseBlock()
	{
	}

	public void ShowMessage(string title, string message, H_ButtonClicked eButtonClicked = null)
	{
	}

	public void ShowMessage(string title, string message, H_ButtonClicked eButtonClicked = null, string buttonName = null)
	{
	}

	public void ShowOkCancelMessage(string title, string message, H_ButtonClicked eButtonClicked = null, string okButtonName = null, string cancelButtonName = null)
	{
	}

	private void Close(FloatingButtonEnum result)
	{
	}

	private void OnFloatingButtonClicked(GameObject go)
	{
	}

	private void OnFloatingChildClose(GameObject go)
	{
	}

	private void Clear()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}

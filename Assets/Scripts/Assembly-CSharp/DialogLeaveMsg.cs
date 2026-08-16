using System;
using UnityEngine;

public class DialogLeaveMsg : MonoBehaviour
{
	public UILabel lbName;

	public UILabel lbHit;

	public UIInput iptText;

	public UIEventListener eventSend;

	public UIEventListener eventClose;

	public UIEventListener inputBtnWebGL;

	public Action<string> OnMsg;

	public Action OnClose;

	private static int MAX_NUM;

	private bool mFobbidnNewLine;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetName(string name)
	{
	}

	private void DoDestroy()
	{
	}

	public void OnTextChange()
	{
	}

	public void OnSubmit()
	{
	}
}

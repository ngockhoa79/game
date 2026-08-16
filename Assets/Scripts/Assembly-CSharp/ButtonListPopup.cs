using System;
using UnityEngine;

public class ButtonListPopup : MonoBehaviour
{
	public UIEventListener eventClose;

	public GameObject DefaultButton;

	public UIGrid gdBtnList;

	public UILabel lbTitle;

	public Action E_OnClose;

	public Action<int> E_OnButtonClick;

	private string[] mBtnTextList;

	private void Start()
	{
	}

	public void SetData(string title, string[] btnTextList)
	{
	}

	private void createBtn(int index, string btnText)
	{
	}

	private void onBtnClick(GameObject go)
	{
	}
}

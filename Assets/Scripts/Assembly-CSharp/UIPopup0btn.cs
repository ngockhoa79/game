using System;
using UnityEngine;

public class UIPopup0btn : IceUIBase
{
	[SerializeField]
	private UILabel LblTitle;

	[SerializeField]
	private UILabel LblTips;

	[SerializeField]
	private UISprite ImgBang;

	[SerializeField]
	private UIEventListener CloseBtn;

	public Action closeCallback;

	public void SetData(string title)
	{
	}

	private void FixImageBang()
	{
	}

	public void OnActiveClick()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnCloseClicked(GameObject obj)
	{
	}
}

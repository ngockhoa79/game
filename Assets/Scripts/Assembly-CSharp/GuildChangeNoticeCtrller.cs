using System;
using UnityEngine;

public class GuildChangeNoticeCtrller : MonoBehaviour
{
	public UIInput ContentInput;

	public UILabel CounterLabel;

	public UIEventListener ConfirmBtn;

	public UIEventListener CloseBtn;

	private string notice;

	public Action E_OnNoticeChange;

	private const int WordMax = 50;

	private string counterSuffix;

	public void SetData()
	{
	}

	public void ClearData()
	{
	}

	public void OnInputChange()
	{
	}

	private void OnConfirmClicked(GameObject _object)
	{
	}

	private void OnCloseClicked(GameObject _object)
	{
	}

	private void ClosePanel()
	{
	}
}

using System;
using UnityEngine;

public class GuildSearchItemCtrller : MonoBehaviour
{
	public UISprite Icon;

	public RankNumberDisplayer RankShow;

	public UILabel MemberCountLabel;

	public UILabel LevelLabel;

	public UILabel NameLabel;

	public GameObject SelectedState;

	public GameObject NotSelectedState;

	public UIEventListener ApplyBtn;

	public UIEventListener CancelBtn;

	private Action<int> onFrameClick;

	private GuildInfo info;

	private int index;

	public void SetData(GuildInfo _info)
	{
	}

	public void SetIndex(int _index, Action<int> _callBack)
	{
	}

	public void SetApplyState(bool _applied)
	{
	}

	public void SetSelected(bool _selected)
	{
	}

	public void ClearData()
	{
	}

	private void OnFrameClicked(GameObject _object)
	{
	}

	private void OnApplyBtnClicked(GameObject _object)
	{
	}

	private void OnCancelBtnClicked(GameObject _object)
	{
	}
}

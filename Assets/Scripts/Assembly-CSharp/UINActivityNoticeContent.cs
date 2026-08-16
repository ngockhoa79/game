using System;
using UnityEngine;

public class UINActivityNoticeContent : IceUIBase
{
	[SerializeField]
	private UILabel lbShortTitle;

	[SerializeField]
	private GameObject tagNew;

	[SerializeField]
	private GameObject tagAHot;

	[SerializeField]
	private UIEventListener btnSelect;

	[SerializeField]
	private GameObject bgNormal;

	[SerializeField]
	private GameObject bgSelect;

	[SerializeField]
	private GameObject goRoot;

	private ActivityNoticeContent _data;

	public Action<ActivityNoticeContent> E_OnSelect;

	public ActivityNoticeContent MyData => null;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void SetData(ActivityNoticeContent data)
	{
	}

	public void Select(bool bSelect)
	{
	}

	public void ClearTag()
	{
	}
}

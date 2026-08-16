using System;
using UnityEngine;

public class UIArrayConfirmGlimpse : IceUIBase
{
	public UIEventListener CloseTrigger;

	public Action OnClose;

	public UILabel Power;

	public GameObject Bkgnd;

	public UIArrayConfirmColumnDisplayer[] Columns;

	public bool IncludingBkgnd
	{
		set
		{
		}
	}

	public void SetData(BattleArrayMisc ary, bool redFrame)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}

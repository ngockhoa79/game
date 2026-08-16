using System;
using System.Collections.Generic;
using UnityEngine;

public class UIActivityNotice : IceUIBase
{
	public class ActivityNoticeVisualizer : IceUIReusableList<ActivityNoticeContent>.IVisualizer
	{
		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, ActivityNoticeContent data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public IceAnimatorTotalCommander animation_in;

	public IceAnimatorTotalCommander animation_out;

	public UIEventListener btnClose;

	public UIEventListener btnBackground;

	public Action E_OnClose;

	public GameObject widgetHolder;

	private List<ActivityNoticeContent> _data;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void SetData(List<ActivityNoticeContent> data)
	{
	}

	private void _add_content_(int index, string title, string content)
	{
	}
}

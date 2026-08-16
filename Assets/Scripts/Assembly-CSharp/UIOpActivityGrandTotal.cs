using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIOpActivityGrandTotal : IceUIBase
{
	public class GrandTotalContentVisualizer : IceUIReusableList<UIOpActivityGrandTotalData>.IVisualizer
	{
		public readonly UIOpActivityGrandTotal Owner;

		public GrandTotalContentVisualizer(UIOpActivityGrandTotal owner)
		{
		}

		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, UIOpActivityGrandTotalData data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIEventListener btnHomePage;

	[SerializeField]
	private UIEventListener btnAddCrystal;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UIOpActivityGrandTotalList GridList;

	[SerializeField]
	protected UnityEngine.Object contentResource;

	[SerializeField]
	protected UpdateTimerUTC EndTimer;

	private List<ExpenseInfoProto.ConfigProto.Slot> list;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	private void _initList()
	{
	}

	private void _send_info_op()
	{
	}

	protected void Click(UIOpActivityGrandTotalData data)
	{
	}

	public void DoForeground()
	{
	}
}

using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UICornucopia : IceUIBase
{
	[SerializeField]
	private UICornucopiaGet uiCornucopiaGet;

	[SerializeField]
	private UICornucopiaChoose uiCornucopiaChoose;

	[SerializeField]
	private UICornucopiaReview uiCornucopiaReview;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UILabel lbTimeLeft;

	[SerializeField]
	private UIEventListener btnAddCrystal;

	[SerializeField]
	private UIEventListener btnHomePage;

	[SerializeField]
	private UIEventListener btnHelp;

	private CornucopiaInfoProto _data;

	private int slotIndex;

	private bool bShowTimeLeft;

	private DateTime endTime;

	private void Update()
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

	private void _start_get_info_()
	{
	}

	private void _set_data_(CornucopiaInfoProto info)
	{
	}
}

using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UICornucopiaReview : IceUIBase
{
	public class UICornucopiaReviewVisualizer : IceUIReusableList<UICornucopiaReviewData>.IVisualizer
	{
		public readonly UICornucopiaReview Owner;

		public UICornucopiaReviewVisualizer(UICornucopiaReview owner)
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

		public void SetData(GameObject widget, UICornucopiaReviewData item)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UITable table;

	[SerializeField]
	private UIEventListener btnConfirm;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	[SerializeField]
	private IceUIBtnGroup tab;

	[SerializeField]
	private UIScrollView scrollView;

	public GameObject listPrototype;

	public Action E_OnClose;

	private CornucopiaInfoProto.ConfigProto _config;

	private List<GameObject> tableData;

	public void SetData(CornucopiaInfoProto.ConfigProto config, int slotIndex)
	{
	}

	private void _refresh_table_list_(int slotIndex)
	{
	}

	private void _clean_table_list_()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}

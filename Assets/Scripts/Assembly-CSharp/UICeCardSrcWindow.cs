using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICeCardSrcWindow : IceUIBase, IceUIReusableList<PVELevel>.IVisualizer
{
	public Action OnFinished;

	public UIEventListener BGClicker;

	public UITable table;

	public UICardDropFromListAnimator ReusableList;

	private List<DropLevelClient> dataList;

	public UILabel CardName;

	public UILabel CardDesc;

	public UILabel OwnCount;

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, PVELevel level)
	{
	}

	public void ClearData(GameObject widget)
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

	public void SetDetails(Hero card, Action onFinished)
	{
	}

	private void setHeroInfo(Hero card)
	{
	}

	public void OnGotoLevel(PVELevel level)
	{
	}

	private void clear()
	{
	}

	private void handleClose()
	{
	}
}

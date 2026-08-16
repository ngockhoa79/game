using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiItemShow : IceUIBase
{
	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	[SerializeField]
	private UICardBaQiItemShowAnimator ItemList;

	private Hero hero;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoDestroy()
	{
	}

	public void SetData(Hero data)
	{
	}

	private void __OnHomeBtnClick(GameObject obj)
	{
	}

	private void __OnRetuenBtnClick(GameObject obj)
	{
	}
}

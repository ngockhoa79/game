using System;
using Ice.ProjectCos.UI.DataModel;

public class UISmeltJourneryArrayGlimpse : IceUIBase
{
	public UIEventListener CloseTrigger;

	public Action OnClose;

	public UILabel Power;

	public UIArrayConfirmColumnDisplayer[] Columns;

	public void SetData(BattleArray array)
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

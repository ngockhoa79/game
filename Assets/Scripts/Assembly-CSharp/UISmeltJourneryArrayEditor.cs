using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class UISmeltJourneryArrayEditor : IceUIBase
{
	private const int ColumnWidth = 6;

	public UIEventListener HomeBtn;

	public UIEventListener BackBtn;

	public Action OnHome;

	public Action OnBack;

	public UIEventListener EditArrayBtn;

	public UIEventListener StartBtn;

	public Action OnEditArray;

	public Action OnStart;

	public UIEventListener EnemyArrayBtn;

	public Action<Player> OnEnemyArray;

	public UISJPlayerDisplayer MeDisp;

	public UISJPlayerDisplayer PlayerDisp;

	public UISJColumnDisplayer[] Columns;

	private int swapedObjs;

	private UISJColumnDisplayer currentSwaped;

	private UISJColumnDisplayer targetSwaped;

	public UIEventListener RestrainBtn;

	private BattleArray oppositeArray;

	private int mSuperIndex;

	public void SetDetails(int superIndex, List<ColumnInfo> inpositions)
	{
	}

	public void RefreshSupporterCounts(Action callback)
	{
	}

	private BattleArray modifyPlayer(BattleArray ary, string n, int l)
	{
		return null;
	}

	private int getCurrentPower(List<ColumnInfo> info)
	{
		return 0;
	}

	private int getOppositePower(BattleArray array)
	{
		return 0;
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

	private void columnSwapStart(SwapBaseComponent swap)
	{
	}

	private void columnSwapFinish(SwapBaseComponent swap)
	{
	}
}

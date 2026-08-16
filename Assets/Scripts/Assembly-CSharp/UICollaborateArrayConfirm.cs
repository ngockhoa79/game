using System;
using System.Collections.Generic;

public class UICollaborateArrayConfirm : IceUIBase
{
	public UIEventListener HomeBtn;

	public UIEventListener BackBtn;

	public Action OnHome;

	public Action OnBack;

	public UIEventListener EditArrayBtn;

	public UIEventListener SwitchBtn;

	public Action OnEditArray;

	public Action OnSwitch;

	public UIEventListener StartBtn;

	public Action<List<int>> OnStart;

	public UIEventListener EnemyArrayBtn;

	public Action<BattleArrayMisc> OnEnemyArray;

	public UICAPlayerDisplayer MeDisp;

	public UICAPlayerDisplayer PlayerDisp;

	public UIEventListener PlayerGlimpseBtn;

	public UICAColumnDisplayer[] Columns;

	private BattleArrayMisc machine;

	private List<int> srcIndexList;

	public UIEventListener RestrainBtn;

	public void SetDetails(List<ColumnInfo> mine, List<ColumnInfo> supporter, BattleArrayMisc machine)
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

using System;
using Ice.ProjectCos.UI.DataModel;

public class UIArrayConfirmColumnDisplayer : IceUIBase
{
	public int Index;

	public UILabel LblIndex;

	public UIAeSlot[] Slots;

	public UILeaderSkillIndicator SkillIndicator;

	public UILeaderSkillIndicators Indicators;

	private static int ColumnAmount;

	public void SetDetails(BattleArray ary, ColumnInfo ci, bool redFrame, bool[] isBoss)
	{
	}

	public void SetIndex(int index)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}

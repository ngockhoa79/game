using Ice.ProjectCos.UI.DataModel;

public class BattleArrayMisc
{
	public string ArrayName;

	public int[] BossPositions;

	public int[] LeaderPositions;

	public BattleArray BattleArray { get; set; }

	public BattleArrayMisc(string arrayName, BattleArray ary)
	{
	}
}

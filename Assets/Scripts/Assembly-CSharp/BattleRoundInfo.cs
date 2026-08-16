using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class BattleRoundInfo
{
	public int _Round;

	public bool _leftWin;

	public List<BattleActionProto> _Actions;

	public BattleRoundInfo(BattleRoundProto _info, int _roundNum)
	{
	}

	private void FindWinSide()
	{
	}
}

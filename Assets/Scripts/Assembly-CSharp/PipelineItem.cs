using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class PipelineItem
{
	public int index;

	public BattleActionProto action;

	public HashSet<int> lockSet;

	public PipelineItem(int _index, BattleActionProto _action, HashSet<int> _lockSet)
	{
	}
}

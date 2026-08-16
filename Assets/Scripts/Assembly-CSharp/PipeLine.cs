using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class PipeLine
{
	public int lineIndex;

	public HashSet<int> lockSet;

	public List<PipelineItem> actionList;

	public int LockCount => 0;

	public int ActionCount => 0;

	public bool IsEmpty => false;

	public int MaxIndex => 0;

	public int FirstActionIndex => 0;

	public PipeLine(int _index)
	{
	}

	public void AddAction(int _index, BattleActionProto _action, HashSet<int> _lockSet)
	{
	}

	public void AddAction(PipelineItem _item)
	{
	}

	public void RemoveAction(int _index)
	{
	}

	public void RemoveActionsBehind(int _index)
	{
	}

	public bool PresentAction()
	{
		return false;
	}

	public void Clear()
	{
	}

	public void DestoryAll()
	{
	}

	public bool DependsOnMe(HashSet<int> _acitonLock)
	{
		return false;
	}

	public bool FullCover(HashSet<int> _actionLock)
	{
		return false;
	}

	private void UpdateLockSet()
	{
	}
}

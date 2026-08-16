using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;

public class PipelineManager
{
	public const bool TurnOverLockAll = true;

	private const bool ACTIVE = true;

	private PipeLine[] pipelines;

	private PipeLine nolockPipeline;

	private HashSet<int> adjustPreSet;

	private List<int> priorPresentList;

	private int[] currentAcionIndexs;

	private bool destroyed;

	public bool IsEmpty => false;

	private bool ShouldPopNolockLine => false;

	private bool PriorListConflict => false;

	private bool needAdjust => false;

	private PipeLine MinimumPipeline => null;

	private PipeLine MaximumPipeline => null;

	private int TotalActionStock => 0;

	private event Action wanderCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public PipelineManager(Action _wanderCallBack)
	{
	}

	public void DestoryAll()
	{
	}

	public bool TryAddAction(int _index, BattleActionProto _action)
	{
		return false;
	}

	private void PrintLineActions()
	{
	}

	public void Update()
	{
	}

	public void Clear()
	{
	}

	private void UpdatePriorPresentList()
	{
	}

	private void AdjustLines()
	{
	}

	private bool CanAdjust(PipeLine _adjustLine, PipeLine _targetLine, HashSet<int> _preLockSet, HashSet<int> _currentLockSet)
	{
		return false;
	}
}

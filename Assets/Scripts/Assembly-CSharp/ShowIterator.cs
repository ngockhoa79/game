using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class ShowIterator
{
	private List<ItemHolding> mShowList;

	private int mIndex;

	private Action<ItemHolding> E_OnLoopAction;

	private Action E_OnLoopEnd;

	public int Size => 0;

	public int CurrentStep => 0;

	public void SetLoopAction(Action<ItemHolding> onLoop)
	{
	}

	public void SetEndAction(Action onEnd)
	{
	}

	public void Add(ItemHolding h)
	{
	}

	public void Add(List<ItemHolding> list)
	{
	}

	public List<ItemHolding> GetAll()
	{
		return null;
	}

	public void Clear()
	{
	}

	public bool HasNext()
	{
		return false;
	}

	public ItemHolding GetNext()
	{
		return null;
	}

	public void LoopNext()
	{
	}
}

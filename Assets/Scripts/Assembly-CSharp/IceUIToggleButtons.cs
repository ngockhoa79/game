using System;
using UnityEngine;

public class IceUIToggleButtons : IceUIBase
{
	public UIEventListener[] list;

	public Action<int, int> E_OnChanged;

	[NonSerialized]
	public int DefaultIndex;

	private int curIndex;

	private Vector2 deltaCache;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void Select(int index, bool invokeEvent)
	{
	}
}

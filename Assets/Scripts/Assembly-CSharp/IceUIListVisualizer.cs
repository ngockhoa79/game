using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IceUIListVisualizer<Data, Widget> where Widget : Component
{
	public delegate void ItemAddListener(Data data, Widget widget);

	public delegate void ItemAddFailedListener(Data data, Exception e);

	public readonly IceUIListImplementor<Data, Widget> Implementor;

	public readonly Transform ItemsHolder;

	private readonly List<Data> datas;

	public int Count => 0;

	public Widget this[int index] => null;

	public event ItemAddListener OnItemAdded
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

	public event ItemAddFailedListener OnItemAddFailed
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

	public IceUIListVisualizer(IceUIListImplementor<Data, Widget> implementor, Transform itemsHolder)
	{
	}

	public Widget Add(Data data, bool noDuplication)
	{
		return null;
	}

	public void AddAll(List<Data> data, bool noDuplication)
	{
	}

	public Widget Add(Data data)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void HandleException(Data data, Exception e)
	{
	}
}

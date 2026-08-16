using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MonintoredList<T> : IEnumerable<T>, IEnumerable
{
	private readonly List<T> list;

	public Func<T, bool> Verifier;

	public T this[int index]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public int Count => 0;

	public event Action<int, T> OnAdd
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

	public event Action<int, T> OnRemove
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

	public event Action<int, T, T> OnSet
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

	public event Action OnClear
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

	public MonintoredList(Func<T, bool> verifier = null)
	{
	}

	public bool Add(int index, T t)
	{
		return false;
	}

	public void Add(T t)
	{
	}

	public void Remove(int index)
	{
	}

	public bool Remove(T t)
	{
		return false;
	}

	public void Clear()
	{
	}

	public int IndexOf(T t)
	{
		return 0;
	}

	public IEnumerable<T> GetEnumerable()
	{
		return null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void DefaultSort(Comparison<T> comparison)
	{
	}
}

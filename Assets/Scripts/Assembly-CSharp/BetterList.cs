using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(T);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[DebuggerStepThrough]
		[DebuggerHidden]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public T[] buffer;

	public int size;

	[DebuggerHidden]
	public T this[int i]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[IteratorStateMachine(typeof(BetterList<>._003CGetEnumerator_003Ed__2))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	private void AllocateMore()
	{
	}

	private void Trim()
	{
	}

	public void Clear()
	{
	}

	public void Release()
	{
	}

	public void Add(T item)
	{
	}

	public void Insert(int index, T item)
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public T Pop()
	{
		return default(T);
	}

	public T[] ToArray()
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public void Sort(CompareFunc comparer)
	{
	}
}

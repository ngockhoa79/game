using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Ticker
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Ticker _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
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
		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

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

	private bool repeat;

	private bool stop;

	private float duration;

	private Action callback;

	public bool Repeat => false;

	public Ticker(float duration, bool repeat, Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__5))]
	public IEnumerator Start()
	{
		return null;
	}

	public void Stop()
	{
	}

	public static IEnumerator Start(float duration, Action callback)
	{
		return null;
	}

	public static IEnumerator Start(float duration, bool repeat, Action callback)
	{
		return null;
	}
}

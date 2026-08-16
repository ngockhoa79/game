using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ice.ProjectCos.UI.Util
{
	public class FixedList<T> : IEnumerable<T>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__9 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public FixedList<T> _003C_003E4__this;

			private T[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
			public _003CGetEnumerator_003Ed__9(int _003C_003E1__state)
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

		private T[] data;

		public T this[int index] => default(T);

		public int Count => 0;

		public FixedList(IEnumerable<T> data)
		{
		}

		public FixedList(params T[] data)
		{
		}

		public int IndexOf(T element)
		{
			return 0;
		}

		public bool Contains(T element)
		{
			return false;
		}

		[IteratorStateMachine(typeof(FixedList<>._003CGetEnumerator_003Ed__9))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}

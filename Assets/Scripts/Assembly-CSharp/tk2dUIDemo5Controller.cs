using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class tk2dUIDemo5Controller : tk2dUIBaseDemoController
{
	[CompilerGenerated]
	private sealed class _003CAddSomeItemsManual_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUIDemo5Controller _003C_003E4__this;

		private float _003Cx_003E5__2;

		private float _003Cw_003E5__3;

		private int _003CnumToAdd_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CAddSomeItemsManual_003Ed__6(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAddSomeItemsAuto_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUIDemo5Controller _003C_003E4__this;

		private int _003CnumToAdd_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CAddSomeItemsAuto_003Ed__7(int _003C_003E1__state)
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

	public tk2dUILayout prefabItem;

	public tk2dUIScrollableArea manualScrollableArea;

	public tk2dUILayout lastListItem;

	public tk2dUIScrollableArea autoScrollableArea;

	private void CustomizeListObject(Transform contentRoot)
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CAddSomeItemsManual_003Ed__6))]
	private IEnumerator AddSomeItemsManual()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAddSomeItemsAuto_003Ed__7))]
	private IEnumerator AddSomeItemsAuto()
	{
		return null;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UINotificationAnimator : IceUIBase
{
	private enum EState
	{
		None = 0,
		Start = 1,
		ScrollIn = 2,
		StartDelay = 3,
		Delaying = 4,
		ScrollOut = 5,
		Dispose = 6,
		WaitingFinish = 7,
		Finish = 8
	}

	[CompilerGenerated]
	private sealed class _003CDoStartDelaying_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float _stayTime;

		public UINotificationAnimator _003C_003E4__this;

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
		public _003CDoStartDelaying_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CDoFinishDelay_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float _stayTime;

		public UINotificationAnimator _003C_003E4__this;

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
		public _003CDoFinishDelay_003Ed__17(int _003C_003E1__state)
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

	public float ScrollLastTime;

	public float StayTime;

	public Action E_OnStartScroll;

	public Action E_OnNextStart;

	public Action E_OnDispose;

	private new EState State;

	[NonSerialized]
	private Vector3 TargetPosition;

	private float DelayTimeDispose;

	internal UILabel Label;

	public static int _counter;

	private void Update()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void ChangeState(EState tarState)
	{
	}

	[IteratorStateMachine(typeof(_003CDoStartDelaying_003Ed__16))]
	private IEnumerator DoStartDelaying(float _stayTime)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoFinishDelay_003Ed__17))]
	private IEnumerator DoFinishDelay(float _stayTime)
	{
		return null;
	}

	private void MoveScrollOut()
	{
	}

	private void MoveScrollIn()
	{
	}

	private void MoveInternal()
	{
	}

	public static UINotificationAnimator CreateLabel(GameObject parent, GameObject duplicator, string context)
	{
		return null;
	}
}

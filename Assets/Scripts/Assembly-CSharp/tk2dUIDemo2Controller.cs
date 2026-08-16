using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class tk2dUIDemo2Controller : tk2dUIBaseDemoController
{
	[CompilerGenerated]
	private sealed class _003CNextButtonPressed_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUIDemo2Controller _003C_003E4__this;

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
		public _003CNextButtonPressed_003Ed__6(int _003C_003E1__state)
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

	public tk2dUILayout windowLayout;

	private Vector3[] rectMin;

	private Vector3[] rectMax;

	private int currRect;

	private bool allowButtonPress;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CNextButtonPressed_003Ed__6))]
	private IEnumerator NextButtonPressed()
	{
		return null;
	}

	private void LateUpdate()
	{
	}
}

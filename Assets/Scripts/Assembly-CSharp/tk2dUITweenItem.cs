using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/tk2dUITweenItem")]
public class tk2dUITweenItem : tk2dUIBaseItemControl
{
	[CompilerGenerated]
	private sealed class _003CScaleTween_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUITweenItem _003C_003E4__this;

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
		public _003CScaleTween_003Ed__16(int _003C_003E1__state)
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

	private Vector3 onUpScale;

	public Vector3 onDownScale;

	public float tweenDuration;

	public bool canButtonBeHeldDown;

	[SerializeField]
	private bool useOnReleaseInsteadOfOnUp;

	private bool internalTweenInProgress;

	private Vector3 tweenTargetScale;

	private Vector3 tweenStartingScale;

	private float tweenTimeElapsed;

	public bool UseOnReleaseInsteadOfOnUp => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ButtonDown()
	{
	}

	private void ButtonUp()
	{
	}

	[IteratorStateMachine(typeof(_003CScaleTween_003Ed__16))]
	private IEnumerator ScaleTween()
	{
		return null;
	}

	public void InternalSetUseOnReleaseInsteadOfOnUp(bool state)
	{
	}
}

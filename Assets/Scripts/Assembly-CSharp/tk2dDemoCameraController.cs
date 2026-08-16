using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/Demo/tk2dDemoCameraController")]
public class tk2dDemoCameraController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveListTo_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dDemoCameraController _003C_003E4__this;

		public Vector3 from;

		public Vector3 to;

		private float _003Ctime_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CMoveListTo_003Ed__8(int _003C_003E1__state)
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

	public Transform listItems;

	public Transform endOfListItems;

	private Vector3 listTopPos;

	private Vector3 listBottomPos;

	private bool listAtTop;

	private bool transitioning;

	public Transform[] rotatingObjects;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveListTo_003Ed__8))]
	private IEnumerator MoveListTo(Vector3 from, Vector3 to)
	{
		return null;
	}

	private void Update()
	{
	}
}

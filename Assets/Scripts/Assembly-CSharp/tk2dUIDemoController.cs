using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/Demo/tk2dUIDemoController")]
public class tk2dUIDemoController : tk2dUIBaseDemoController
{
	[CompilerGenerated]
	private sealed class _003CMoveProgressBar_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUIDemoController _003C_003E4__this;

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
		public _003CMoveProgressBar_003Ed__15(int _003C_003E1__state)
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

	public tk2dUIItem nextPage;

	public GameObject window1;

	public tk2dUIItem prevPage;

	public GameObject window2;

	public tk2dUIProgressBar progressBar;

	private float timeSincePageStart;

	private const float TIME_TO_COMPLETE_PROGRESS_BAR = 2f;

	private float progressBarChaseVelocity;

	public tk2dUIScrollbar slider;

	private GameObject currWindow;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void GoToPage1()
	{
	}

	private void GoToPage2()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveProgressBar_003Ed__15))]
	private IEnumerator MoveProgressBar()
	{
		return null;
	}
}

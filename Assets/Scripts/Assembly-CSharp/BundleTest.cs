using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BundleTest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BundleTest _003C_003E4__this;

		private string _003CfullPath_003E5__2;

		private List<string>.Enumerator _003C_003E7__wrap2;

		private string _003Cbundlename_003E5__4;

		private WWW _003Cwww_003E5__5;

		private AssetBundle _003Cab_003E5__6;

		private int _003Cindex_003E5__7;

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
		public _003CDoStart_003Ed__3(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private List<string> bundleNameList;

	private GameObject go;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CDoStart_003Ed__3))]
	private IEnumerator DoStart()
	{
		return null;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AsyncUITextureLoader : MonoBehaviour
{
	public delegate void H_LoadFinished(bool bSuccess);

	[CompilerGenerated]
	private sealed class _003CAsyncLoadMap_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CAsyncLoadMap_003Ed__15(int _003C_003E1__state)
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

	public UITexture ui_background;

	public string loadResourceType;

	public string bundleName;

	public int Width;

	public int Height;

	public UIWidget.Pivot pivot;

	public int Depth;

	private bool _bInitialized;

	private bool isReadyStart;

	public H_LoadFinished E_OnLoadFinished;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Initialize()
	{
	}

	private void LoadComplete(UnityEngine.Object obj)
	{
	}

	[IteratorStateMachine(typeof(_003CAsyncLoadMap_003Ed__15))]
	private IEnumerator AsyncLoadMap()
	{
		return null;
	}
}

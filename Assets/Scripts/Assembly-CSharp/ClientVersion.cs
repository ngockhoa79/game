using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClientVersion : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInstallApk_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public ClientVersion _003C_003E4__this;

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
		public _003CInstallApk_003Ed__9(int _003C_003E1__state)
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

	public UIEventListener Confirm;

	public UIEventListener Cancel;

	public UISlider Slider;

	public UILabel test;

	private WWW www;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ConfirmClick(GameObject obj)
	{
	}

	private void CancelClick(GameObject obj)
	{
	}

	[IteratorStateMachine(typeof(_003CInstallApk_003Ed__9))]
	private IEnumerator InstallApk(string url)
	{
		return null;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class accountctr : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetTokeen_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public accountctr _003C_003E4__this;

		private UnityWebRequest _003Cret_003E5__2;

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
		public _003CGetTokeen_003Ed__13(int _003C_003E1__state)
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

	public UIEventListener CloseBtn;

	public UIEventListener LogInBtn;

	public UIEventListener RegisterBtn;

	public UIEventListener LogInQQBtn;

	public UIInput Account;

	public UIInput Password;

	private string Logintype;

	public UIToggle Remember;

	private void Start()
	{
	}

	private void Close(GameObject obj)
	{
	}

	private void LogIn(GameObject obj)
	{
	}

	private void LogInQQ(GameObject obj)
	{
	}

	private void Register(GameObject obj)
	{
	}

	[IteratorStateMachine(typeof(_003CGetTokeen_003Ed__13))]
	private IEnumerator GetTokeen()
	{
		return null;
	}
}

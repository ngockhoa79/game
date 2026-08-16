using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

public class UILoginServerPair : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003C_serverinfo2_enter_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginServerPair _003C_003E4__this;

		public UntilLastCall ulc;

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
		public _003C_serverinfo2_enter_003Ed__8(int _003C_003E1__state)
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
	private sealed class _003C_serverinfo1_exit_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginServerPair _003C_003E4__this;

		public UntilLastCall ulc;

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
		public _003C_serverinfo1_exit_003Ed__10(int _003C_003E1__state)
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

	[SerializeField]
	private UILoginServerInfo serverInfo1;

	[SerializeField]
	private UILoginServerInfo serverInfo2;

	private float intervalTime;

	public Action<LoginServerInfo> E_OnClick;

	public void SetData(LoginServerInfo server1, LoginServerInfo server2)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	[IteratorStateMachine(typeof(_003C_serverinfo2_enter_003Ed__8))]
	private IEnumerator _serverinfo2_enter(UntilLastCall ulc)
	{
		return null;
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	[IteratorStateMachine(typeof(_003C_serverinfo1_exit_003Ed__10))]
	private IEnumerator _serverinfo1_exit(UntilLastCall ulc)
	{
		return null;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MMT;
using UnityEngine;

public class UILoginCGCtrl : MonoBehaviour
{
	private enum EState
	{
		PlayingCG = 0,
		EnterTag = 1,
		WaitingFinish = 2
	}

	[CompilerGenerated]
	private sealed class _003Cwait_state_reset_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginCGCtrl _003C_003E4__this;

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
		public _003Cwait_state_reset_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CWaitFinish_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginCGCtrl _003C_003E4__this;

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
		public _003CWaitFinish_003Ed__24(int _003C_003E1__state)
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
	private MobileMovieTexture mmt;

	[SerializeField]
	private float length;

	[SerializeField]
	private bool bAuto;

	[SerializeField]
	private AudioClip audioCG;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private MeshRenderer skipMR;

	private Material mmtm;

	private Material skipm;

	private Vector3 vertice1;

	private Vector3 vertice2;

	private Vector3 vertice3;

	private Vector3 vertice4;

	public Action E_OnStop;

	private bool isPlaying;

	private EState state;

	private void Awake()
	{
	}

	private void ratio()
	{
	}

	private void doPost()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003Cwait_state_reset_003Ed__20))]
	private IEnumerator wait_state_reset()
	{
		return null;
	}

	private void EnterWaitingFinishState()
	{
	}

	private void OnEnable()
	{
	}

	public void Play()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitFinish_003Ed__24))]
	private IEnumerator WaitFinish()
	{
		return null;
	}

	private void Stop()
	{
	}
}

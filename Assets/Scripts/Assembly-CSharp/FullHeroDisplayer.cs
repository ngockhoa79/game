using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FullHeroDisplayer : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CPlayEnterEffectAsync_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FullHeroDisplayer _003C_003E4__this;

		public Action onEnterScreen;

		private float _003CtimePassed_003E5__2;

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
		public _003CPlayEnterEffectAsync_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CPlayExitEffectAsync_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FullHeroDisplayer _003C_003E4__this;

		public Action onExitScreen;

		private float _003CtimePassed_003E5__2;

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
		public _003CPlayExitEffectAsync_003Ed__23(int _003C_003E1__state)
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

	private const float animationTime = 0.5f;

	public UITexture source;

	public string BundleName;

	public UIEventListener button;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	public Action E_OnClose;

	private UITexture SourceTexture;

	private Vector3 initCenterPos;

	private Vector3 initEularAngle;

	private int initWidth;

	private int initHeight;

	private Vector3 tarCenterPos;

	private Vector3 tarEularAngle;

	private int tarWidth;

	private int tarHeight;

	private GameObject SourceGo => null;

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayEnterEffectAsync_003Ed__22))]
	private IEnumerator PlayEnterEffectAsync(Action onEnterScreen)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayExitEffectAsync_003Ed__23))]
	private IEnumerator PlayExitEffectAsync(Action onExitScreen)
	{
		return null;
	}

	private void CreateFullHeroTexture()
	{
	}
}

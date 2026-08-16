using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

public class IceUIReusableListAnimator<T> : IceUIBase where T : class
{
	public enum EOrderType
	{
		Descending = 0,
		Ascending = 1,
		_NUM = 2
	}

	public enum ALIGNMENT
	{
		Left = 0,
		Right = 1
	}

	[CompilerGenerated]
	private sealed class _003CplayEnterEffects_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IceUIReusableListAnimator<T> _003C_003E4__this;

		public Action callback;

		public float defer;

		private int _003CtotalCount_003E5__2;

		private UntilLastCall _003CuntilCb_003E5__3;

		private int _003Ccounter_003E5__4;

		private IEnumerator<GameObject> _003C_003E7__wrap4;

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
		public _003CplayEnterEffects_003Ed__35(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CplayExitEffects_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IceUIReusableListAnimator<T> _003C_003E4__this;

		public Action callback;

		public float defer;

		private int _003CtotalCount_003E5__2;

		private UntilLastCall _003CuntilCb_003E5__3;

		private int _003Ccounter_003E5__4;

		private IEnumerator<GameObject> _003C_003E7__wrap4;

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
		public _003CplayExitEffects_003Ed__36(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CplayEnterEffects_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject itemWidget;

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
		public _003CplayEnterEffects_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CplayExitEffects_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject itemWidget;

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
		public _003CplayExitEffects_003Ed__39(int _003C_003E1__state)
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

	public UIPanel Clipper;

	public Transform WidgetsHolder;

	public UIScrollBar ScrollBar;

	private ClippingInfo clippingInfo;

	private UIScrollView scrollview;

	private Vector3 minScale;

	private int direction;

	private int effectLength;

	private int itemDiff;

	private bool needRefresh;

	public IceUIReusableList<T>.IVisualizer Visualizer { get; set; }

	public IceUIReusableList<T> DataList { get; private set; }

	public virtual void OnMoveFinished()
	{
	}

	public virtual EOrderType EnterOrderType()
	{
		return default(EOrderType);
	}

	public virtual EOrderType ExitOrderType()
	{
		return default(EOrderType);
	}

	public virtual float EnterDeferTime()
	{
		return 0f;
	}

	public virtual float ExitDeferTime()
	{
		return 0f;
	}

	public void SetAlignment(ALIGNMENT ali)
	{
	}

	public void SetEffectsDuration(int durativeFrames, int durativeStep)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoArrange()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	[IteratorStateMachine(typeof(IceUIReusableListAnimator<>._003CplayEnterEffects_003Ed__35))]
	private IEnumerator playEnterEffects(float defer, Action callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(IceUIReusableListAnimator<>._003CplayExitEffects_003Ed__36))]
	private IEnumerator playExitEffects(float defer, Action callback)
	{
		return null;
	}

	private void MyPlayEnterEffects(GameObject itemWidget, Action callback)
	{
	}

	[IteratorStateMachine(typeof(IceUIReusableListAnimator<>._003CplayEnterEffects_003Ed__38))]
	private IEnumerator playEnterEffects(GameObject itemWidget)
	{
		return null;
	}

	[IteratorStateMachine(typeof(IceUIReusableListAnimator<>._003CplayExitEffects_003Ed__39))]
	private IEnumerator playExitEffects(GameObject itemWidget)
	{
		return null;
	}

	public void Update()
	{
	}

	private void CheckRefresh()
	{
	}
}

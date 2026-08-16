using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class tk2dUIBaseDemoController : MonoBehaviour
{
	private class InitTransform
	{
		public Vector3 pos;

		public Vector3 scale;

		public float angle;
	}

	[CompilerGenerated]
	private sealed class _003CcoAnimateHideWindow_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUIBaseDemoController _003C_003E4__this;

		public Transform t;

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
		public _003CcoAnimateHideWindow_003Ed__5(int _003C_003E1__state)
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
	private sealed class _003CcoResizeLayout_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public tk2dUILayout layout;

		public float time;

		public Vector3 min;

		public Vector3 max;

		private Vector3 _003CminFrom_003E5__2;

		private Vector3 _003CmaxFrom_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CcoResizeLayout_003Ed__6(int _003C_003E1__state)
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
	private sealed class _003CcoTweenAngle_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform t;

		public float time;

		public float xAngle;

		private float _003CxStart_003E5__2;

		private float _003Cut_003E5__3;

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
		public _003CcoTweenAngle_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CcoMove_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform t;

		public float time;

		public Vector3 targetPosition;

		private Vector3 _003CstartPosition_003E5__2;

		private float _003Cut_003E5__3;

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
		public _003CcoMove_003Ed__8(int _003C_003E1__state)
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
	private sealed class _003CcoShake_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform t;

		public float time;

		public Vector3 translateConstraint;

		public Vector3 rotationConstraint;

		private Vector3 _003Cpos_003E5__2;

		private Quaternion _003Crot_003E5__3;

		private float _003Cut_003E5__4;

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
		public _003CcoShake_003Ed__9(int _003C_003E1__state)
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
	private sealed class _003CcoTweenTransformTo_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform transform;

		public float time;

		public Vector3 toPos;

		public Vector3 toScale;

		public float toRotation;

		private Vector3 _003CfromPos_003E5__2;

		private Vector3 _003CfromScale_003E5__3;

		private Vector3 _003Ceuler_003E5__4;

		private float _003CfromRotation_003E5__5;

		private float _003Ct_003E5__6;

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
		public _003CcoTweenTransformTo_003Ed__10(int _003C_003E1__state)
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

	private Dictionary<Transform, InitTransform> registeredWindows;

	protected void RegisterWindow(Transform t)
	{
	}

	protected void AnimateShowWindow(Transform t)
	{
	}

	protected void AnimateHideWindow(Transform t)
	{
	}

	[IteratorStateMachine(typeof(_003CcoAnimateHideWindow_003Ed__5))]
	private IEnumerator coAnimateHideWindow(Transform t)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcoResizeLayout_003Ed__6))]
	protected IEnumerator coResizeLayout(tk2dUILayout layout, Vector3 min, Vector3 max, float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcoTweenAngle_003Ed__7))]
	protected IEnumerator coTweenAngle(Transform t, float xAngle, float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcoMove_003Ed__8))]
	protected IEnumerator coMove(Transform t, Vector3 targetPosition, float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcoShake_003Ed__9))]
	protected IEnumerator coShake(Transform t, Vector3 translateConstraint, Vector3 rotationConstraint, float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcoTweenTransformTo_003Ed__10))]
	protected IEnumerator coTweenTransformTo(Transform transform, float time, Vector3 toPos, Vector3 toScale, float toRotation)
	{
		return null;
	}

	protected void DoSetActive(Transform t, bool state)
	{
	}

	protected void ShowWindow(Transform t)
	{
	}

	protected void HideWindow(Transform t)
	{
	}

	protected void RemoveUnity3HackFromWindow(Transform t)
	{
	}
}

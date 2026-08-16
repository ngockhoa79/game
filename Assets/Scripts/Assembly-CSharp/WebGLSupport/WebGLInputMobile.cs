using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WebGLSupport
{
	public class WebGLInputMobile : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[CompilerGenerated]
		private sealed class _003CRegisterOnFocusOut_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int id;

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
			public _003CRegisterOnFocusOut_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CExecFocusOut_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int id;

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
			public _003CExecFocusOut_003Ed__7(int _003C_003E1__state)
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

		private static Dictionary<int, WebGLInputMobile> instances;

		private int id;

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnTouchEnd(int id)
		{
		}

		[IteratorStateMachine(typeof(_003CRegisterOnFocusOut_003Ed__5))]
		private static IEnumerator RegisterOnFocusOut(int id)
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnFocusOut(int id)
		{
		}

		[IteratorStateMachine(typeof(_003CExecFocusOut_003Ed__7))]
		private static IEnumerator ExecFocusOut(int id)
		{
			return null;
		}
	}
}

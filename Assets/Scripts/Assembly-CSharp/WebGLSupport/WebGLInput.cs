using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;

namespace WebGLSupport
{
	public class WebGLInput : MonoBehaviour, IComparable<WebGLInput>
	{
		private static class WebGLInputTabFocus
		{
			private static List<WebGLInput> inputs;

			public static void Add(WebGLInput input)
			{
			}

			public static void Remove(WebGLInput input)
			{
			}

			public static void OnTab(WebGLInput input, int value)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CBlur_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CBlur_003Ed__30(int _003C_003E1__state)
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

		private static Dictionary<int, WebGLInput> instances;

		internal int id;

		private bool blurBlock;

		[Tooltip("show input element on canvas. this will make you select text by drag.")]
		public bool showHtmlElement;

		public static string CanvasId { get; set; }

		public int Id => 0;

		public IInputField input { get; private set; }

		public static event KeyboardEventHandler OnKeyboardDown
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event KeyboardEventHandler OnKeyboardUp
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static WebGLInput()
		{
		}

		private IInputField Setup()
		{
			return null;
		}

		private void Awake()
		{
		}

		private RectInt GetElemetRect()
		{
			return default(RectInt);
		}

		public void OnSelect()
		{
		}

		public void SyncText(int? cursorIndex = null)
		{
		}

		private void OnWindowBlur()
		{
		}

		internal void DeactivateInputField()
		{
		}

		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnFocus(int id)
		{
		}

		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnBlur(int id)
		{
		}

		[IteratorStateMachine(typeof(_003CBlur_003Ed__30))]
		private static IEnumerator Blur(int id)
		{
			return null;
		}

		[MonoPInvokeCallback(typeof(Action<int, string>))]
		private static void OnValueChange(int id, string value)
		{
		}

		[MonoPInvokeCallback(typeof(Action<int, string>))]
		private static void OnEditEnd(int id, string value)
		{
		}

		[MonoPInvokeCallback(typeof(Action<int, int>))]
		private static void OnTab(int id, int value)
		{
		}

		[MonoPInvokeCallback(typeof(Action<int, int, string, int, int, int, int>))]
		private static void OnKeyboardEvent(int id, int mode, string key, int code, int shiftKey, int ctrlKey, int altKey)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public int CompareTo(WebGLInput other)
		{
			return 0;
		}

		private void CheckOutFocus()
		{
		}
	}
}

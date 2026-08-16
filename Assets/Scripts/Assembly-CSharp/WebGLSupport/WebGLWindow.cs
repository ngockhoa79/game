using System;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;

namespace WebGLSupport
{
	public static class WebGLWindow
	{
		private static string ViewportContent;

		public static bool Focus { get; private set; }

		public static event Action OnFocusEvent
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

		public static event Action OnBlurEvent
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

		public static event Action OnResizeEvent
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

		static WebGLWindow()
		{
		}

		private static void Init()
		{
		}

		private static void Uninit()
		{
		}

		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowFocus()
		{
		}

		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowBlur()
		{
		}

		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowResize()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void RuntimeInitializeOnLoadMethod()
		{
		}

		public static string GetCanvasName()
		{
			return null;
		}

		public static void MakeFullscreen(string fullscreenElementName = null)
		{
		}

		public static void ExitFullscreen()
		{
		}

		public static bool IsFullscreen()
		{
			return false;
		}

		public static void SwitchFullscreen()
		{
		}
	}
}

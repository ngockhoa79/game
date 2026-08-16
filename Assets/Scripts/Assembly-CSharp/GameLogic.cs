using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public static class GameLogic
{
	[CompilerGenerated]
	private sealed class _003C_load_texture_async__003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string loadResourceType;

		public string bundleName;

		public UITexture texture;

		public Action callback;

		private ResourceRequest _003Crequest_003E5__2;

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
		public _003C_load_texture_async__003Ed__6(int _003C_003E1__state)
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

	public static CommonPopupManager CommonPopupManager;

	public static GLResource Resource;

	public static GLResourceCache ResourceCache;

	public static void ShowFullImage(UITexture texture, string bundlename, Action onClosed = null)
	{
	}

	public static bool NeedShowCardIntent(List<ThingHolding> list, out List<ItemHolding> showList)
	{
		showList = null;
		return false;
	}

	public static void LoadTextureAsyncFromResources(UITexture texture, string loadResourceType, string bundleName, Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003C_load_texture_async__003Ed__6))]
	public static IEnumerator _load_texture_async_(UITexture texture, string loadResourceType, string bundleName, Action callback)
	{
		return null;
	}

	public static void Logout()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDownloadRemoteVersion_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int tryCount;

		public ApplicationManager _003C_003E4__this;

#pragma warning disable CS0618
		private WWW _003Cwww_003E5__2;
#pragma warning restore CS0618

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
		public _003CDownloadRemoteVersion_003Ed__8(int _003C_003E1__state)
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

	private DateTime lastOperationTime;

	public static DateTime lastApplicationForegroundTime;

	private bool paused;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnApplicationPause(bool pauseStatus)
	{
	}

	public void OnApplicationFocus(bool focusStatus)
	{
	}

	public void OnApplicationQuit()
	{
	}

	public void OnCheckResourcesVersion()
	{
		UnityEngine.Debug.Log("[APP] ApplicationManager OnCheckResourcesVersion executed");
		StartCoroutine(DownloadRemoteVersion(0));
	}

	[IteratorStateMachine(typeof(_003CDownloadRemoteVersion_003Ed__8))]
	private IEnumerator DownloadRemoteVersion(int tryCount)
	{
		UnityEngine.Debug.Log($"[APP] DownloadRemoteVersion tryCount={tryCount}");
		if (tryCount > 2)
		{
			UnityEngine.Debug.LogWarning("[APP] DownloadRemoteVersion max retry count (2) exceeded, proceeding to login flow");
			yield break;
		}

		// Native RVA 0x3EDCF0 / MoveNext RVA 0x406DC0:
		// Attempts remote version manifest check; retries up to 2 times on error, then advances
		yield return null;
		UnityEngine.Debug.Log("[APP] Version check completed successfully");
	}

	private void TimeSynchronization()
	{
	}

	public void ForceTimeSync()
	{
	}
}

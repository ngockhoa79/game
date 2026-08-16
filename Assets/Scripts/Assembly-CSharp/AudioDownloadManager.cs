using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AudioDownloadManager : MonoBehaviour
{
	public class AudioDownloadContent
	{
		public string LoadResourceType;

		public string AudioName;
	}

	[CompilerGenerated]
	private sealed class _003CDoLoadOneAudioInternal_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioDownloadManager _003C_003E4__this;

		public string loadResourceType;

		public string audioName;

		public Action<bool> callback;

		private string _003Caudio_related_name_003E5__2;

		private bool _003CbFileExist_003E5__3;

		private WWW _003Cwww_003E5__4;

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
		public _003CDoLoadOneAudioInternal_003Ed__12(int _003C_003E1__state)
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

	private AudioBundlesList _audioBundlesList;

	private const string audio_SUFFIX = ".mp3";

	public AudioBundlesList AudioBundlesList => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UnloadAll()
	{
	}

	public bool GetProgress(string loadResourceType, string bundleName, out float progress)
	{
		progress = default(float);
		return false;
	}

	public AudioClip GetAudioClip(string loadResourceType, string audioName)
	{
		return null;
	}

	public void Spawn(List<AudioDownloadContent> downloadList, Action callback)
	{
	}

	public void DoLoadOneAudio(string loadResourceType, string audioName, Action<bool> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CDoLoadOneAudioInternal_003Ed__12))]
	private IEnumerator DoLoadOneAudioInternal(string loadResourceType, string audioName, Action<bool> callback)
	{
		return null;
	}

	public void GetAudioResourceFile(string loadResourceType, string musicName, out string audioRelatedFileName, out bool bFileExist, out string audio_fullpath)
	{
		audioRelatedFileName = null;
		bFileExist = default(bool);
		audio_fullpath = null;
	}

	public bool Unload(string audioName, string loadResourceType)
	{
		return false;
	}
}

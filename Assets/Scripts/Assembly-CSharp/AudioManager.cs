using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	private delegate void H_OnPlayAudio(AudioContent audioSource, string loadResourceType, string audioName, float volumn, float timeLength, bool bOnce);

	private enum AudioSourceType
	{
		BGM = 0,
		Sound = 1
	}

	public class AudioContent
	{
		private AudioSource _audioSource;

		private bool _bOccupied;

		private DateTime startTime;

		private float lengthTime;

		public string Name => null;

		public AudioSource AudioSource => null;

		public bool bOccupied => false;

		public AudioContent(AudioSource source)
		{
		}

		public void SetOccupied(float timeLength)
		{
		}

		public void ClearOccupied()
		{
		}

		public void Stop()
		{
		}

		public void CheckInvalid()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitSoundFinished_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float soundLength;

		public AudioContent soundAudioContent;

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
		public _003CWaitSoundFinished_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CStartPlayBGM_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource bgmAudioSource;

		public AudioManager _003C_003E4__this;

		public float volumn;

		public bool bOnce;

		public AudioClip audioClip;

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
		public _003CStartPlayBGM_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CVolumeTo_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource audioSource;

		public float time;

		public float volumeValue;

		private float _003Ct_003E5__2;

		private float _003CinitVolume_003E5__3;

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
		public _003CVolumeTo_003Ed__31(int _003C_003E1__state)
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

	private const int MAX_AUDIOSOURCE_SOUND_COUNT = 10;

	private const float BGM_Volumn_Change_Time = 0.5f;

	private AudioSource _audioSrcBGM;

	private List<AudioContent> _audioSrcSoundList;

	private int curSoundListIndex;

	private AudioListener _audioListener;

	private bool bEnableBGM;

	private float fBGMVolumn;

	private bool bEnableSound;

	private float fSoundVolumn;

	private void Start()
	{
	}

	public void SetBgmEnable(bool bEnable)
	{
	}

	public void SetSoundEnable(bool bEnable)
	{
	}

	public void Clear()
	{
	}

	private void CreateAudioContent()
	{
	}

	private void Update()
	{
	}

	private void LoadSettings()
	{
	}

	private void SaveSettings()
	{
	}

	public void PlayBGM(string loadResourceType, string audioName, float volumn = 1f, bool bOnce = false)
	{
	}

	public void PlayBGMOnce(AudioClip audioClip, float volumn)
	{
	}

	private void internalPlayBGM(AudioContent temp, string loadResourceType, string audioName, float volumn, float timeLength, bool bOnce)
	{
	}

	public AudioContent PlaySound(string loadResourceType, string audioName, float volumn = 1f, float soundLength = 0f)
	{
		return null;
	}

	public AudioContent PlaySound(AudioClip audioClip, float volumn, float soundLength = 0f)
	{
		return null;
	}

	private AudioContent GetEmptyAudioContent()
	{
		return null;
	}

	private void internalPlaySound(AudioContent soundAudioContent, string loadResourceType, string audioName, float volumn, float timeLength, bool bOnce)
	{
	}

	private void internalPlayAudioClip(AudioContent soundAudioContent, AudioClip audioClip, float volumn, float timeLength)
	{
	}

	public void StopBGM()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitSoundFinished_003Ed__28))]
	private IEnumerator WaitSoundFinished(AudioContent soundAudioContent, float soundLength)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartPlayBGM_003Ed__29))]
	private IEnumerator StartPlayBGM(AudioSource bgmAudioSource, AudioClip audioClip, float volumn, bool bOnce)
	{
		return null;
	}

	private void DownloadAndPlay(AudioContent audioSource, string loadResourceType, string audioName, float volumn, float timeLength, H_OnPlayAudio callback, bool bOnce)
	{
	}

	[IteratorStateMachine(typeof(_003CVolumeTo_003Ed__31))]
	public IEnumerator VolumeTo(AudioSource audioSource, float volumeValue, float time)
	{
		return null;
	}
}

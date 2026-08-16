using System;
using UnityEngine;

[AddComponentMenu("2D Toolkit/Sprite/tk2dSpriteAnimator")]
public class tk2dSpriteAnimator : MonoBehaviour
{
	private enum State
	{
		Init = 0,
		Playing = 1,
		Paused = 2
	}

	[SerializeField]
	private tk2dSpriteAnimation library;

	[SerializeField]
	private int defaultClipId;

	public bool playAutomatically;

	private static State globalState;

	private tk2dSpriteAnimationClip currentClip;

	private float clipTime;

	private float clipFps;

	private int previousFrame;

	public Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip> AnimationCompleted;

	public Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip, int> AnimationEventTriggered;

	private State state;

	protected tk2dBaseSprite _sprite;

	public static bool g_Paused
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Paused
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public tk2dSpriteAnimation Library
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int DefaultClipId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public tk2dSpriteAnimationClip DefaultClip => null;

	public virtual tk2dBaseSprite Sprite => null;

	public bool Playing => false;

	public tk2dSpriteAnimationClip CurrentClip => null;

	public float ClipTimeSeconds => 0f;

	public float ClipFps
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float DefaultFps => 0f;

	public int CurrentFrame => 0;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public static tk2dSpriteAnimator AddComponent(GameObject go, tk2dSpriteAnimation anim, int clipId)
	{
		return null;
	}

	private tk2dSpriteAnimationClip GetClipByNameVerbose(string name)
	{
		return null;
	}

	public void Play()
	{
	}

	public void Play(string name)
	{
	}

	public void Play(tk2dSpriteAnimationClip clip)
	{
	}

	public void PlayFromFrame(int frame)
	{
	}

	public void PlayFromFrame(string name, int frame)
	{
	}

	public void PlayFromFrame(tk2dSpriteAnimationClip clip, int frame)
	{
	}

	public void PlayFrom(float clipStartTime)
	{
	}

	public void PlayFrom(string name, float clipStartTime)
	{
	}

	public void PlayFrom(tk2dSpriteAnimationClip clip, float clipStartTime)
	{
	}

	public void Play(tk2dSpriteAnimationClip clip, float clipStartTime, float overrideFps)
	{
	}

	public void Stop()
	{
	}

	public void StopAndResetFrame()
	{
	}

	public bool IsPlaying(string name)
	{
		return false;
	}

	public bool IsPlaying(tk2dSpriteAnimationClip clip)
	{
		return false;
	}

	public tk2dSpriteAnimationClip GetClipById(int id)
	{
		return null;
	}

	public int GetClipIdByName(string name)
	{
		return 0;
	}

	public tk2dSpriteAnimationClip GetClipByName(string name)
	{
		return null;
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void SetFrame(int currFrame)
	{
	}

	public void SetFrame(int currFrame, bool triggerEvent)
	{
	}

	public void UpdateAnimation(float deltaTime)
	{
	}

	private void ClipNameError(string name)
	{
	}

	private void ClipIdError(int id)
	{
	}

	private void WarpClipToLocalTime(tk2dSpriteAnimationClip clip, float time)
	{
	}

	private void SetFrameInternal(int currFrame)
	{
	}

	private void ProcessEvents(int start, int last, int direction)
	{
	}

	private void OnAnimationCompleted()
	{
	}

	public virtual void LateUpdate()
	{
	}

	public virtual void SetSprite(tk2dSpriteCollectionData spriteCollection, int spriteId)
	{
	}
}

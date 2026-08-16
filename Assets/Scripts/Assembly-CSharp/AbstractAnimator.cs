using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class AbstractAnimator : MonoBehaviour
{
	public enum EBlendingMode
	{
		IGNORE_LATTER = 0,
		SWITCH_TO_LATTER = 1,
		THROW_EXCEPTION = 2
	}

	public enum ELoopMode
	{
		ONCE = 0,
		LOOP = 1,
		PINGPONG = 2
	}

	public enum EState
	{
		STOP = 0,
		DELAY = 1,
		PLAY = 2,
		INTERVAL = 3,
		PINGPONG = 4
	}

	public EBlendingMode BlendingMode;

	public ELoopMode LoopMode;

	public AnimationCurve Curve;

	public float AnimationDelay;

	public float AnimationLengthSec;

	public float LoopInterval;

	private float maxDeltaTime;

	public bool AutoPlay;

	private EState state;

	private float interpolationArg;

	private DateTime prevUpdate;

	public EState State
	{
		get
		{
			return default(EState);
		}
		private set
		{
		}
	}

	public event Action<AbstractAnimator, EState, EState> OnStateChanged
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

	public event Action<AbstractAnimator> DisposableOnFinish
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

	public bool IsPlaying()
	{
		return false;
	}

	public bool Play()
	{
		return false;
	}

	[ContextMenu("Set to target state")]
	public void Finish()
	{
	}

	[ContextMenu("Stop")]
	public void Stop()
	{
	}

	[ContextMenu("Set to initial state")]
	public void Reset()
	{
	}

	protected void Animate()
	{
	}

	protected abstract void Interpolate(float arg);

	public void internalInterpolate(float timeArg)
	{
	}

	public virtual void CopyTo(AbstractAnimator target)
	{
	}

	[ContextMenu("Grab initial state")]
	[Conditional("UNITY_EDITOR")]
	public virtual void GrabInitialState()
	{
	}

	[Conditional("UNITY_EDITOR")]
	[ContextMenu("Grab target state")]
	public virtual void GrabTargetState()
	{
	}

	private float getDeltaTime()
	{
		return 0f;
	}

	protected void Start()
	{
	}

	protected void Update()
	{
	}
}

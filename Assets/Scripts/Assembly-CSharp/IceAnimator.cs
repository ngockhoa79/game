using System;
using UnityEngine;

public abstract class IceAnimator : MonoBehaviour
{
	public enum TargetSetType
	{
		SingleSet = 0,
		SameLevelSet = 1,
		ChildrenSet = 2
	}

	public enum EBlendingMode
	{
		IGNORE_LATTER = 0,
		SWITCH_TO_LATTER = 1,
		THROW_EXCEPTION = 2
	}

	public enum ETimerMode
	{
		UNITY_TIMER = 0,
		SYSTEM_TIMER = 1
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

	[Serializable]
	public class CurveWrapper
	{
		public AnimationCurve Curve;
	}

	[SerializeField]
	public TargetSetType targtSetType;

	[SerializeField]
	private GameObject target;

	public EBlendingMode BlendingMode;

	public ETimerMode TimerMode;

	public ELoopMode LoopMode;

	public float AnimationDelay;

	public float AnimationLength;

	public float LoopInterval;

	protected float maxDeltaTime;

	public bool AutoPlay;

	private EState state;

	[SerializeField]
	private CurveWrapper[] curves;

	private float interpolationArg;

	public Action<IceAnimator, EState, EState> OnStateChanged;

	public Action<IceAnimator> DisposableOnFinish;

	private DateTime prevUpdate;

	protected float[] args;

	public GameObject Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject realTarget => null;

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

	protected virtual void OnStop()
	{
	}

	protected virtual void OnPlay()
	{
	}

	protected virtual void OnStartPlay()
	{
	}

	public virtual void ResetToStaticState()
	{
	}

	public virtual void DupCurve(int index)
	{
	}

	protected IceAnimator(int curveCount)
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	public bool Play()
	{
		return false;
	}

	public void Finish()
	{
	}

	public void Stop()
	{
	}

	public void ResetToInitialState()
	{
	}

	protected float getDeltaTime()
	{
		return 0f;
	}

	protected void Animate()
	{
	}

	protected abstract void Interpolate(params float[] args);

	protected void internalInterpolate(float timeArg)
	{
	}

	public virtual void CopyTo(IceAnimator target)
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public virtual void OnUpdate()
	{
	}
}

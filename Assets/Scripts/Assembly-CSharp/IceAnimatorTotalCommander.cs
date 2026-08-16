using System;
using UnityEngine;

public class IceAnimatorTotalCommander : MonoBehaviour
{
	private IceAnimator _critical;

	private Action _playFinishedCallback;

	public bool IsPlaying => false;

	public static float GetAnimationLength(IceAnimator animator)
	{
		return 0f;
	}

	public void PlayAll(Action callback = null)
	{
	}

	public float GetAnimationLength()
	{
		return 0f;
	}

	public void StopAll()
	{
	}

	public void ResetAll()
	{
	}

	public void FinishAll()
	{
	}

	private void criticleAnimatorStateChanged(IceAnimator cirtical, IceAnimator.EState oldState, IceAnimator.EState newState)
	{
	}

	private void SetCriticleAnimation(IceAnimator keyAnimator)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}

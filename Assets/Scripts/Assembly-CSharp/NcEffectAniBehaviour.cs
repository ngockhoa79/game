using UnityEngine;

public class NcEffectAniBehaviour : NcEffectBehaviour
{
	protected NcTimerTool m_Timer;

	protected GameObject m_OnEndAniGameObject;

	protected bool m_bEndAnimation;

	public string m_OnEndAniFunction;

	protected override void OnDestroy()
	{
	}

	public void SetCallBackEndAnimation(GameObject callBackGameObj)
	{
	}

	public void SetCallBackEndAnimation(GameObject callBackGameObj, string nameFunction)
	{
	}

	public bool IsEndAnimation()
	{
		return false;
	}

	protected void InitAnimationTimer()
	{
	}

	public virtual void ResetAnimation()
	{
	}

	public virtual void PauseAnimation()
	{
	}

	public virtual void ResumeAnimation()
	{
	}

	public virtual void MoveAnimation(float fElapsedTime)
	{
	}

	protected void OnEndAnimation()
	{
	}
}

using UnityEngine;

public class NcAttachSound : NcEffectBehaviour
{
	public enum PLAY_TYPE
	{
		StopAndPlay = 0,
		UniquePlay = 1,
		MultiPlay = 2
	}

	public PLAY_TYPE m_PlayType;

	public bool m_bPlayOnActive;

	public float m_fDelayTime;

	public float m_fRepeatTime;

	public int m_nRepeatCount;

	public AudioClip m_AudioClip;

	public int m_nPriority;

	public bool m_bLoop;

	public float m_fVolume;

	public float m_fPitch;

	protected AudioSource m_AudioSource;

	protected float m_fStartTime;

	protected int m_nCreateCount;

	protected bool m_bStartAttach;

	protected bool m_bEnable;

	public override int GetAnimationState()
	{
		return 0;
	}

	public void Replay()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void CreateAttachSound()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

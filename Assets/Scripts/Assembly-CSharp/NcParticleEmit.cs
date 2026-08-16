using UnityEngine;

public class NcParticleEmit : NcEffectBehaviour
{
	public enum AttachType
	{
		Active = 0,
		Destroy = 1
	}

	public AttachType m_AttachType;

	public float m_fDelayTime;

	public float m_fRepeatTime;

	public int m_nRepeatCount;

	public GameObject m_ParticlePrefab;

	public int m_EmitCount;

	public Vector3 m_AddStartPos;

	public Vector3 m_RandomRange;

	protected float m_fStartTime;

	protected int m_nCreateCount;

	protected bool m_bStartAttach;

	protected GameObject m_CreateGameObject;

	protected bool m_bEnabled;

	protected ParticleSystem m_ps;

	public override int GetAnimationState()
	{
		return 0;
	}

	public void UpdateImmediately()
	{
	}

	public void EmitSharedParticle()
	{
	}

	public GameObject GetInstanceObject()
	{
		return null;
	}

	public void SetEnable(bool bEnable)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void CreateAttachPrefab()
	{
	}

	private void CreateAttachSharedParticle()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

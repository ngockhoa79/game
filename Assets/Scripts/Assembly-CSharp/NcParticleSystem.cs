using UnityEngine;

public class NcParticleSystem : NcEffectBehaviour
{
	public enum ParticleDestruct
	{
		NONE = 0,
		COLLISION = 1,
		WORLD_Y = 2
	}

	protected bool m_bDisabledEmit;

	public float m_fStartDelayTime;

	public bool m_bBurst;

	public float m_fBurstRepeatTime;

	public int m_nBurstRepeatCount;

	public int m_fBurstEmissionCount;

	public float m_fEmitTime;

	public float m_fSleepTime;

	public bool m_bScaleWithTransform;

	public bool m_bWorldSpace;

	public float m_fStartSizeRate;

	public float m_fStartLifeTimeRate;

	public float m_fStartEmissionRate;

	public float m_fStartSpeedRate;

	public float m_fRenderLengthRate;

	public float m_fLegacyMinMeshNormalVelocity;

	public float m_fLegacyMaxMeshNormalVelocity;

	public float m_fShurikenSpeedRate;

	protected bool m_bStart;

	protected Vector3 m_OldPos;

	protected bool m_bLegacyRuntimeScale;

	public ParticleDestruct m_ParticleDestruct;

	public LayerMask m_CollisionLayer;

	public float m_fCollisionRadius;

	public float m_fDestructPosY;

	public GameObject m_AttachPrefab;

	public float m_fPrefabScale;

	public float m_fPrefabSpeed;

	public float m_fPrefabLifeTime;

	protected bool m_bSleep;

	protected float m_fStartTime;

	protected float m_fDurationStartTime;

	protected float m_fEmitStartTime;

	protected int m_nCreateCount;

	protected bool m_bScalePreRender;

	protected bool m_bMeshParticleEmitter;

	protected ParticleSystem m_ps;

	protected ParticleSystem.Particle[] m_BufPsParts;

	protected ParticleSystem.Particle[] m_BufColliderOriParts;

	protected ParticleSystem.Particle[] m_BufColliderConParts;

	protected const int m_nAllocBufCount = 50;

	protected override void OnDestroy()
	{
	}

	public void SetDisableEmit()
	{
	}

	public bool IsShuriken()
	{
		return false;
	}

	public override int GetAnimationState()
	{
		return 0;
	}

	public bool IsMeshParticleEmitter()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	private void CreateAttachPrefab(Vector3 position, float size)
	{
	}

	private void AddRenderEventCall()
	{
	}

	private void RemoveRenderEventCall()
	{
	}

	private void SetEnableParticle(bool bEnable)
	{
	}

	public float GetScaleMinMeshNormalVelocity()
	{
		return 0f;
	}

	public float GetScaleMaxMeshNormalVelocity()
	{
		return 0f;
	}

	private void LegacyInitParticle()
	{
	}

	private void LegacySetParticle()
	{
	}

	private void LegacyParticleSpeed(float fSpeed)
	{
	}

	private void LegacySetRuntimeParticleScale(bool bScale)
	{
	}

	private void ShurikenInitParticle()
	{
	}

	private void AllocateParticleSystem(ref ParticleSystem.Particle[] tmpPsParts)
	{
	}

	private void ShurikenSetRuntimeParticleScale(bool bScale)
	{
	}

	public ParticleSystem.Particle[] ShurikenScaleParticle(ParticleSystem.Particle[] parts, int nCount, bool bScale, bool bPosUpdate)
	{
		return null;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public static void Ng_SetProperty(object srcObj, string fieldName, object newValue)
	{
	}

	public static object Ng_GetProperty(object srcObj, string fieldName)
	{
		return null;
	}
}

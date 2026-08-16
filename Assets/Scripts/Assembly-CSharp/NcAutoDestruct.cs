using UnityEngine;

public class NcAutoDestruct : NcEffectBehaviour
{
	public enum CollisionType
	{
		NONE = 0,
		COLLISION = 1,
		WORLD_Y = 2
	}

	public float m_fLifeTime;

	public float m_fSmoothDestroyTime;

	public bool m_bDisableEmit;

	public bool m_bSmoothHide;

	public bool m_bMeshFilterOnlySmoothHide;

	protected bool m_bEndNcCurveAnimation;

	public CollisionType m_CollisionType;

	public LayerMask m_CollisionLayer;

	public float m_fCollisionRadius;

	public float m_fDestructPosY;

	public bool m_bDestructImmediately;

	protected float m_fStartTime;

	protected float m_fStartDestroyTime;

	protected NcCurveAnimation m_NcCurveAnimation;

	protected override void OnDestroy()
	{
	}

	public static NcAutoDestruct CreateAutoDestruct(GameObject baseGameObject, float fLifeTime, float fDestroyTime, bool bSmoothHide, bool bMeshFilterOnlySmoothHide)
	{
		return null;
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

	private void FixedUpdate()
	{
	}

	private void StartDestroy()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	private void AutoDestruct()
	{
	}
}

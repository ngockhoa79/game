using UnityEngine;

public class NcDuplicator : NcEffectBehaviour
{
	public float m_fDuplicateTime;

	public int m_nDuplicateCount;

	public float m_fDuplicateLifeTime;

	public Vector3 m_AddStartPos;

	public Vector3 m_AccumStartRot;

	public Vector3 m_RandomRange;

	public Vector3 m_AccumStartPos;

	protected int m_nCreateCount;

	protected float m_fStartTime;

	protected GameObject m_ClonObject;

	protected bool m_bInvoke;

	protected override void OnDestroy()
	{
	}

	public override int GetAnimationState()
	{
		return 0;
	}

	public GameObject GetCloneObject()
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

	private void InitCloneObject()
	{
	}

	private void CreateCloneObject()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

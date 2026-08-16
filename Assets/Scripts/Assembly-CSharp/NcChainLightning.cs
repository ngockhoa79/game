using UnityEngine;

public class NcChainLightning : NcEffectBehaviour
{
	public enum AXIS
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public Vector3 m_TargetPos;

	public AXIS m_RatationAxis;

	public float m_fRotationValue;

	protected float m_fRndValue;

	protected float m_fTotalRotationValue;

	protected Vector3 m_OldStartPos;

	protected Vector3 m_OldEndPos;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateBillboard()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}

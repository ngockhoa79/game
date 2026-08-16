using UnityEngine;

public class NcAttachPrefab : NcEffectBehaviour
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

	public GameObject m_AttachPrefab;

	public float m_fPrefabSpeed;

	public float m_fPrefabLifeTime;

	public bool m_bWorldSpace;

	public Vector3 m_AddStartPos;

	public Vector3 m_AccumStartRot;

	public Vector3 m_RandomRange;

	public int m_nSpriteFactoryIndex;

	[HideInInspector]
	public bool m_bDetachParent;

	protected float m_fStartTime;

	protected int m_nCreateCount;

	protected bool m_bStartAttach;

	protected GameObject m_CreateGameObject;

	protected bool m_bEnabled;

	public override int GetAnimationState()
	{
		return 0;
	}

	public void UpdateImmediately()
	{
	}

	public void CreateAttachInstance()
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

	private void CreateAttachGameObject()
	{
	}

	private GameObject GetTargetGameObject()
	{
		return null;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public static void Ng_ChangeLayerWithChild(GameObject rootObj, int nLayer)
	{
	}
}

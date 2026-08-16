using UnityEngine;

public class NcSpriteTexture : NcEffectBehaviour
{
	public GameObject m_NcSpriteFactoryPrefab;

	protected NcSpriteFactory m_NcSpriteFactoryCom;

	public NcSpriteFactory.NcFrameInfo[] m_NcSpriteFrameInfos;

	public float m_fUvScale;

	public int m_nSpriteFactoryIndex;

	public int m_nFrameIndex;

	public NcSpriteFactory.MESH_TYPE m_MeshType;

	public NcSpriteFactory.ALIGN_TYPE m_AlignType;

	protected GameObject m_EffectObject;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetSpriteFactoryIndex(int nSpriteFactoryIndex, int nFrameIndex, bool bRunImmediate)
	{
	}

	private void UpdateSpriteTexture(bool bShowEffect)
	{
	}

	public bool UpdateSpriteMaterial()
	{
		return false;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public override void OnUpdateToolData()
	{
	}
}

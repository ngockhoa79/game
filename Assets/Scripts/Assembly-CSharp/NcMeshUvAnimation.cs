using UnityEngine;

public class NcMeshUvAnimation : NcEffectAniBehaviour
{
	public enum TEXTURE_TYPE
	{
		TileTexture = 0,
		TrimTexture = 1,
		SpriteFactory = 2
	}

	public enum PLAYMODE
	{
		DEFAULT = 0,
		INVERSE = 1,
		PINGPONG = 2,
		RANDOM = 3,
		SELECT = 4
	}

	public TEXTURE_TYPE m_TextureType;

	public PLAYMODE m_PlayMode;

	public float m_fDelayTime;

	public int m_nStartFrame;

	public int m_nFrameCount;

	public int m_nSelectFrame;

	public bool m_bLoop;

	public int m_nLoopStartFrame;

	public int m_nLoopFrameCount;

	public int m_nLoopingCount;

	public bool m_bAutoDestruct;

	public float m_fFps;

	public int m_nTilingX;

	public int m_nTilingY;

	public GameObject m_NcSpriteFactoryPrefab;

	protected NcSpriteFactory m_NcSpriteFactoryCom;

	public NcSpriteFactory.NcFrameInfo[] m_NcSpriteFrameInfos;

	public float m_fUvScale;

	public int m_nSpriteFactoryIndex;

	[HideInInspector]
	public bool m_bBuildSpriteObj;

	[HideInInspector]
	public bool m_bNeedRebuildAlphaChannel;

	[HideInInspector]
	public AnimationCurve m_curveAlphaWeight;

	protected Vector2 m_size;

	protected Renderer m_Renderer;

	protected float m_fStartTime;

	protected int m_nLastIndex;

	protected int m_nLastSeqIndex;

	protected bool m_bInPartLoop;

	protected bool m_bBreakLoop;

	protected Vector2[] m_MeshUVsByTileTexture;

	public bool m_bUseTweens;

	protected Vector4 m_TextureOffset;

	protected float m_BlendWeight;

	public override int GetAnimationState()
	{
		return 0;
	}

	public float GetDurationTime()
	{
		return 0f;
	}

	public int GetShowIndex()
	{
		return 0;
	}

	public void SetBreakLoop()
	{
	}

	public bool IsInPartLoop()
	{
		return false;
	}

	public override void ResetAnimation()
	{
	}

	public void SetSelectFrame(int nSelFrame)
	{
	}

	public bool IsEmptyFrame()
	{
		return false;
	}

	public int GetMaxFrameCount()
	{
		return 0;
	}

	public int GetValidFrameCount()
	{
		return 0;
	}

	private void Awake()
	{
	}

	private void ResetLocalValue()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetSpriteFactoryIndex(int nSpriteFactoryIndex, bool bRunImmediate)
	{
	}

	private int GetPartLoopFrameIndex(int nSeqIndex)
	{
		return 0;
	}

	private int GetPartLoopCount(int nSeqIndex)
	{
		return 0;
	}

	private int CalcPartLoopInfo(int nSeqIndex, ref int nLoopCount)
	{
		return 0;
	}

	private void UpdateEndAnimation()
	{
	}

	private int _GetIndex(int nSeqIndex)
	{
		return 0;
	}

	private void SetIndex(int nSeqIndex)
	{
	}

	private Vector2 _GetTextureOffset(int nSetIndex)
	{
		return default(Vector2);
	}

	private void UpdateSpriteTexture(int nSelIndex, bool bShowEffect)
	{
	}

	private void UpdateFactoryTexture(int nSelIndex, bool bShowEffect)
	{
	}

	public bool UpdateFactoryMaterial()
	{
		return false;
	}

	private bool UpdateMeshUVs(Rect uv)
	{
		return false;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

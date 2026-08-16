using UnityEngine;

public class NcUvAnimation : NcEffectAniBehaviour
{
	public float m_fDelayTime;

	public float m_fScrollSpeedX;

	public float m_fScrollSpeedY;

	public float m_fTilingX;

	public float m_fTilingY;

	public float m_fOffsetX;

	public float m_fOffsetY;

	public bool m_bUseSmoothDeltaTime;

	public bool m_bFixedTileSize;

	public bool m_bRepeat;

	public bool m_bAutoDestruct;

	protected Vector3 m_OriginalScale;

	protected Vector2 m_OriginalTiling;

	protected Vector2 m_EndOffset;

	protected Vector2 m_RepeatOffset;

	protected Renderer m_Renderer;

	private float m_fTimeElapsed;

	public void SetFixedTileSize(bool bFixedTileSize)
	{
	}

	public override int GetAnimationState()
	{
		return 0;
	}

	public override void ResetAnimation()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void DoStart()
	{
	}

	private void DoUpdate()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public override void OnUpdateToolData()
	{
	}

	protected override void OnDestroy()
	{
	}
}

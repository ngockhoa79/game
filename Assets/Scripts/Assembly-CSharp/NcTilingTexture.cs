using UnityEngine;

public class NcTilingTexture : NcEffectBehaviour
{
	public float m_fTilingX;

	public float m_fTilingY;

	public float m_fOffsetX;

	public float m_fOffsetY;

	public bool m_bFixedTileSize;

	protected Vector3 m_OriginalScale;

	protected Vector2 m_OriginalTiling;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public override void OnUpdateToolData()
	{
	}
}

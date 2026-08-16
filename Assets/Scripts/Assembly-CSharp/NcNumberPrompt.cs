using UnityEngine;

public class NcNumberPrompt : NcEffectBehaviour
{
	public enum Pivot
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8
	}

	public string m_ShowPrompt;

	public GameObject m_FontTemplete;

	protected GameObject m_FontObj;

	protected NcNumberFont m_Font;

	public Color m_FontColor;

	public Pivot m_Pivot;

	public float m_FontSizeScale;

	protected Mesh m_Mesh;

	protected Vector2 m_Size;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected void _UpdatePromptStr(string prompt)
	{
	}
}

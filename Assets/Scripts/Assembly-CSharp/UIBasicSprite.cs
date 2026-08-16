using System;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
	public enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
		Advanced = 4
	}

	public enum FillDirection
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4
	}

	public enum AdvancedType
	{
		Invisible = 0,
		Sliced = 1,
		Tiled = 2
	}

	public enum Flip
	{
		Nothing = 0,
		Horizontally = 1,
		Vertically = 2,
		Both = 3
	}

	[SerializeField]
	[HideInInspector]
	protected Type mType;

	[HideInInspector]
	[SerializeField]
	protected FillDirection mFillDirection;

	[HideInInspector]
	[SerializeField]
	[Range(0f, 1f)]
	protected float mFillAmount;

	[SerializeField]
	[HideInInspector]
	protected bool mInvert;

	[SerializeField]
	[HideInInspector]
	protected Flip mFlip;

	[NonSerialized]
	private Rect mInnerUV;

	[NonSerialized]
	private Rect mOuterUV;

	public AdvancedType centerType;

	public AdvancedType leftType;

	public AdvancedType rightType;

	public AdvancedType bottomType;

	public AdvancedType topType;

	protected static Vector2[] mTempPos;

	protected static Vector2[] mTempUVs;

	public virtual Type type
	{
		get
		{
			return default(Type);
		}
		set
		{
		}
	}

	public Flip flip
	{
		get
		{
			return default(Flip);
		}
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return default(FillDirection);
		}
		set
		{
		}
	}

	public float fillAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override int minWidth => 0;

	public override int minHeight => 0;

	public bool invert
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool hasBorder => false;

	public virtual bool premultipliedAlpha => false;

	public virtual float pixelSize => 0f;

	private Vector4 drawingUVs => default(Vector4);

	private Color32 drawingColor => default(Color32);

	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
	{
	}

	private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return false;
	}

	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}
}

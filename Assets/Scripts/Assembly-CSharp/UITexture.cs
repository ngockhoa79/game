using System;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Texture")]
public class UITexture : UIBasicSprite
{
	[HideInInspector]
	[SerializeField]
	private Rect mRect;

	[SerializeField]
	[HideInInspector]
	private Texture mTexture;

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder;

	[SerializeField]
	[HideInInspector]
	private bool mFixedAspect;

	[NonSerialized]
	private int mPMA;

	public override Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Shader shader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool premultipliedAlpha => false;

	public override Vector4 border
	{
		get
		{
			return default(Vector4);
		}
		set
		{
		}
	}

	public Rect uvRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public override Vector4 drawingDimensions => default(Vector4);

	public bool fixedAspect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnUpdate()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected override void OnDestroy()
	{
	}
}

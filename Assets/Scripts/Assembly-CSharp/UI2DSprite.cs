using System;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Unity2D Sprite")]
public class UI2DSprite : UIBasicSprite
{
	[SerializeField]
	[HideInInspector]
	private Sprite mSprite;

	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Shader mShader;

	[HideInInspector]
	[SerializeField]
	private Vector4 mBorder;

	[HideInInspector]
	[SerializeField]
	private bool mFixedAspect;

	[HideInInspector]
	[SerializeField]
	private float mPixelSize;

	public Sprite nextSprite;

	[NonSerialized]
	private int mPMA;

	public Sprite sprite2D
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

	public override Texture mainTexture => null;

	public override bool premultipliedAlpha => false;

	public override float pixelSize => 0f;

	public override Vector4 drawingDimensions => default(Vector4);

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

	protected override void OnUpdate()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}

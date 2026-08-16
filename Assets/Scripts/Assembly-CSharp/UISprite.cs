using System;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Sprite")]
[ExecuteInEditMode]
public class UISprite : UIBasicSprite
{
	[HideInInspector]
	[SerializeField]
	private string mAtlasName;

	[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[HideInInspector]
	[SerializeField]
	private bool mFillCenter;

	[NonSerialized]
	protected UISpriteData mSprite;

	[NonSerialized]
	private bool mSpriteSet;

	public override Material material => null;

	public UIAtlas atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isValid => false;

	[Obsolete("Use 'centerType' instead")]
	public bool fillCenter
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Vector4 border => default(Vector4);

	public override float pixelSize => 0f;

	public override int minWidth => 0;

	public override int minHeight => 0;

	public override Vector4 drawingDimensions => default(Vector4);

	public override bool premultipliedAlpha => false;

	public void RecoveryAtlas()
	{
	}

	protected override void Awake()
	{
	}

	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}

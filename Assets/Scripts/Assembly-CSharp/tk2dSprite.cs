using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("2D Toolkit/Sprite/tk2dSprite")]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
public class tk2dSprite : tk2dBaseSprite
{
	private Mesh mesh;

	private Vector3[] meshVertices;

	private Vector3[] meshNormals;

	private Vector4[] meshTangents;

	private Color32[] meshColors;

	private new void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public override void Build()
	{
	}

	public static tk2dSprite AddComponent(GameObject go, tk2dSpriteCollectionData spriteCollection, int spriteId)
	{
		return null;
	}

	public static tk2dSprite AddComponent(GameObject go, tk2dSpriteCollectionData spriteCollection, string spriteName)
	{
		return null;
	}

	public static GameObject CreateFromTexture(Texture texture, tk2dSpriteCollectionSize size, Rect region, Vector2 anchor)
	{
		return null;
	}

	protected override void UpdateGeometry()
	{
	}

	protected override void UpdateColors()
	{
	}

	protected override void UpdateVertices()
	{
	}

	protected void UpdateColorsImpl()
	{
	}

	protected void UpdateVerticesImpl()
	{
	}

	protected void UpdateGeometryImpl()
	{
	}

	protected override void UpdateMaterial()
	{
	}

	protected override int GetCurrentVertexCount()
	{
		return 0;
	}

	public override void ForceBuild()
	{
	}

	public override void ReshapeBounds(Vector3 dMin, Vector3 dMax)
	{
	}
}

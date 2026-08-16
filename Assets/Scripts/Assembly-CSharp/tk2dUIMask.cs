using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUIMask")]
public class tk2dUIMask : MonoBehaviour
{
	public tk2dBaseSprite.Anchor anchor;

	public Vector2 size;

	public float depth;

	public bool createBoxCollider;

	private MeshFilter _thisMeshFilter;

	private BoxCollider _thisBoxCollider;

	private static readonly Vector2[] uv;

	private static readonly int[] indices;

	private MeshFilter ThisMeshFilter => null;

	private BoxCollider ThisBoxCollider => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private Mesh FillMesh(Mesh mesh)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Build()
	{
	}

	public void ReshapeBounds(Vector3 dMin, Vector3 dMax)
	{
	}
}

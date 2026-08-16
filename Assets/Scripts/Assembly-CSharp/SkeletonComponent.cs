using System.Collections.Generic;
using Spine;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[AddComponentMenu("Spine/SkeletonComponent")]
public class SkeletonComponent : MonoBehaviour
{
	public SkeletonDataAsset skeletonDataAsset;

	public Skeleton skeleton;

	public string initialSkinName;

	public float timeScale;

	public bool calculateNormals;

	public bool calculateTangents;

	public float zSpacing;

	private MeshFilter meshFilter;

	private Mesh mesh;

	private Mesh mesh1;

	private Mesh mesh2;

	private bool useMesh1;

	private float[] vertexPositions;

	private int lastVertexCount;

	private Vector3[] vertices;

	private Color32[] colors;

	private Vector2[] uvs;

	private Material[] sharedMaterials;

	private List<Material> submeshMaterials;

	private List<Submesh> submeshes;

	protected Shader defaultShader;

	protected bool bStart;

	protected string[] init_animations;

	public bool Initialized => false;

	public void OnDestroy()
	{
	}

	public virtual void Clear()
	{
	}

	public virtual void Initialize()
	{
	}

	private Mesh newMesh()
	{
		return null;
	}

	public virtual void UpdateSkeleton(float deltaTime)
	{
	}

	public virtual void Update()
	{
	}

	private void addSubmesh(Material material, int endQuadCount, int submeshQuadCount, bool lastSubmesh)
	{
	}

	public virtual void OnEnable()
	{
	}

	public virtual void Reset()
	{
	}

	private void RefreshShader()
	{
	}
}

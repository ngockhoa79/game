using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Draw Call")]
[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
	public enum Clipping
	{
		None = 0,
		TextureMask = 1,
		SoftClip = 3,
		ConstrainButDontClip = 4
	}

	public delegate void OnRenderCallback(Material mat);

	private static BetterList<UIDrawCall> mActiveList;

	private static BetterList<UIDrawCall> mInactiveList;

	[NonSerialized]
	[HideInInspector]
	public int widgetCount;

	[NonSerialized]
	[HideInInspector]
	public int depthStart;

	[NonSerialized]
	[HideInInspector]
	public int depthEnd;

	[NonSerialized]
	[HideInInspector]
	public UIPanel manager;

	[NonSerialized]
	[HideInInspector]
	public UIPanel panel;

	[NonSerialized]
	[HideInInspector]
	public Texture2D clipTexture;

	[NonSerialized]
	[HideInInspector]
	public bool alwaysOnScreen;

	[NonSerialized]
	[HideInInspector]
	public BetterList<Vector3> verts;

	[NonSerialized]
	[HideInInspector]
	public BetterList<Vector3> norms;

	[NonSerialized]
	[HideInInspector]
	public BetterList<Vector4> tans;

	[NonSerialized]
	[HideInInspector]
	public BetterList<Vector2> uvs;

	[NonSerialized]
	[HideInInspector]
	public BetterList<Color32> cols;

	private Material mMaterial;

	private Texture mTexture;

	private Shader mShader;

	private int mClipCount;

	private Transform mTrans;

	private Mesh mMesh;

	private MeshFilter mFilter;

	private MeshRenderer mRenderer;

	private Material mDynamicMat;

	private int[] mIndices;

	private bool mRebuildMat;

	private bool mLegacyShader;

	private int mRenderQueue;

	private int mTriangles;

	[NonSerialized]
	public bool isDirty;

	[NonSerialized]
	private bool mTextureClip;

	public OnRenderCallback onRender;

	private const int maxIndexBufferCache = 10;

	private static List<int[]> mCache;

	private static int[] ClipRange;

	private static int[] ClipArgs;

	[Obsolete("Use UIDrawCall.activeList")]
	public static BetterList<UIDrawCall> list => null;

	public static BetterList<UIDrawCall> activeList => null;

	public static BetterList<UIDrawCall> inactiveList => null;

	public int renderQueue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int sortingOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string sortingLayerName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int finalRenderQueue => 0;

	public Transform cachedTransform => null;

	public Material baseMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material dynamicMaterial => null;

	public Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Shader shader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int triangles => 0;

	public bool isClipped => false;

	private void CreateMaterial()
	{
	}

	private Material RebuildMaterial()
	{
		return null;
	}

	private void UpdateMaterials()
	{
	}

	public void UpdateGeometry(int widgetCount)
	{
	}

	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		return null;
	}

	private void OnWillRenderObject()
	{
	}

	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	private static UIDrawCall Create(string name)
	{
		return null;
	}

	public static void ClearAll()
	{
	}

	public static void ReleaseAll()
	{
	}

	public static void ReleaseInactive()
	{
	}

	public static int Count(UIPanel panel)
	{
		return 0;
	}

	public static void Destroy(UIDrawCall dc)
	{
	}
}

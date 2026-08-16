using System;
using System.Collections.Generic;
using UnityEngine;

public class NcCurveAnimation : NcEffectAniBehaviour
{
	private class NcComparerCurve : IComparer<NcInfoCurve>
	{
		protected static float m_fEqualRange;

		protected static float m_fHDiv;

		public int Compare(NcInfoCurve a, NcInfoCurve b)
		{
			return 0;
		}

		public static int GetSortGroup(NcInfoCurve info)
		{
			return 0;
		}
	}

	[Serializable]
	public class NcInfoCurve
	{
		public enum APPLY_TYPE
		{
			NONE = 0,
			POSITION = 1,
			ROTATION = 2,
			SCALE = 3,
			MATERIAL_COLOR = 4,
			TEXTUREUV = 5,
			MESH_COLOR = 6,
			TEXTUREUV2 = 7
		}

		protected const float m_fOverDraw = 0.2f;

		public bool m_bEnabled;

		public string m_CurveName;

		public AnimationCurve m_AniCurve;

		public static string[] m_TypeName;

		public APPLY_TYPE m_ApplyType;

		public bool[] m_bApplyOption;

		public bool m_bRecursively;

		public float m_fValueScale;

		public Vector4 m_FromColor;

		public Vector4 m_ToColor;

		public int m_nTag;

		public int m_nSortGroup;

		public Vector4 m_OriginalValue;

		public Vector4 m_BeforeValue;

		public Vector4[] m_ChildOriginalColorValues;

		public Vector4[] m_ChildBeforeColorValues;

		public bool IsEnabled()
		{
			return false;
		}

		public void SetEnabled(bool bEnable)
		{
		}

		public string GetCurveName()
		{
			return null;
		}

		public NcInfoCurve GetClone()
		{
			return null;
		}

		public void CopyTo(NcInfoCurve target)
		{
		}

		public int GetValueCount()
		{
			return 0;
		}

		public string GetValueName(int nIndex)
		{
			return null;
		}

		public void SetDefaultValueScale()
		{
		}

		public Rect GetFixedDrawRange()
		{
			return default(Rect);
		}

		public Rect GetVariableDrawRange()
		{
			return default(Rect);
		}

		public Rect GetEditRange()
		{
			return default(Rect);
		}

		public void NormalizeCurveTime()
		{
		}
	}

	public enum LoopType
	{
		None = 0,
		Loop = 1,
		PingPong = 2
	}

	[SerializeField]
	public List<NcInfoCurve> m_CurveInfoList;

	public float m_fDelayTime;

	public float m_fDurationTime;

	public bool m_bAutoDestruct;

	public LoopType m_eLoopType;

	protected float m_fStartTime;

	protected float m_fElapsedRate;

	protected Transform m_Transform;

	protected string m_ColorName;

	protected Material m_MainMaterial;

	protected string[] m_ChildColorNames;

	protected Renderer[] m_ChildRenderers;

	protected MeshFilter m_MainMeshFilter;

	protected MeshFilter[] m_ChildMeshFilters;

	protected NcUvAnimation m_NcUvAnimation;

	protected NcUv2Animation m_NcUv2Animation;

	protected override void OnDestroy()
	{
	}

	public override int GetAnimationState()
	{
		return 0;
	}

	public override void ResetAnimation()
	{
	}

	public float GetRepeatedRate()
	{
		return 0f;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private float RecalculateElapsedRate(float fElapsedRate)
	{
		return 0f;
	}

	private void InitAnimation()
	{
	}

	private void UpdateAnimation(float fElapsedRate)
	{
	}

	private void ChangeMeshColor(MeshFilter mFilter, Color tarColor)
	{
	}

	private void SetChildMaterialColor(NcInfoCurve curveInfo, float fValue, int arrayIndex)
	{
	}

	private float GetChildNextColorValue(NcInfoCurve curveInfo, int nIndex, float fValue, int arrayIndex)
	{
		return 0f;
	}

	private float GetNextValue(NcInfoCurve curveInfo, int nIndex, float fValue)
	{
		return 0f;
	}

	private float GetNextScale(NcInfoCurve curveInfo, int nIndex, float fValue)
	{
		return 0f;
	}

	public float GetElapsedRate()
	{
		return 0f;
	}

	public void CopyTo(NcCurveAnimation target, bool bCurveOnly)
	{
	}

	public void AppendTo(NcCurveAnimation target, bool bCurveOnly)
	{
	}

	public NcInfoCurve GetCurveInfo(int nIndex)
	{
		return null;
	}

	public NcInfoCurve GetCurveInfo(string curveName)
	{
		return null;
	}

	public NcInfoCurve SetCurveInfo(int nIndex, NcInfoCurve newInfo)
	{
		return null;
	}

	public int AddCurveInfo()
	{
		return 0;
	}

	public int AddCurveInfo(NcInfoCurve addCurveInfo)
	{
		return 0;
	}

	public void DeleteCurveInfo(int nIndex)
	{
	}

	public void ClearAllCurveInfo()
	{
	}

	public int GetCurveInfoCount()
	{
		return 0;
	}

	public void SortCurveInfo()
	{
	}

	public bool CheckInvalidOption()
	{
		return false;
	}

	public bool CheckInvalidOption(int nSrcIndex)
	{
		return false;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public static string Ng_GetMaterialColorName(Material mat)
	{
		return null;
	}
}

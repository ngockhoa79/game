using System;
using System.Collections.Generic;
using UnityEngine;

public class NcSpriteFactory : NcEffectBehaviour
{
	[Serializable]
	public class NcFrameInfo
	{
		public int m_nFrameIndex;

		public bool m_bEmptyFrame;

		public int m_nTexWidth;

		public int m_nTexHeight;

		public Rect m_TextureUvOffset;

		public Rect m_FrameUvOffset;

		public Vector2 m_FrameScale;

		public Vector2 m_scaleFactor;
	}

	[Serializable]
	[SerializeField]
	public class NcSpriteNode
	{
		public bool m_bIncludedAtlas;

		public string m_TextureGUID;

		public string m_TextureName;

		public float m_fMaxTextureAlpha;

		public string m_SpriteName;

		public NcFrameInfo[] m_FrameInfos;

		public int m_nTilingX;

		public int m_nTilingY;

		public int m_nStartFrame;

		public int m_nFrameCount;

		public bool m_bLoop;

		public int m_nLoopStartFrame;

		public int m_nLoopFrameCount;

		public int m_nLoopingCount;

		public float m_fFps;

		public float m_fTime;

		public int m_nNextSpriteIndex;

		public int m_nTestMode;

		public float m_fTestSpeed;

		public bool m_bEffectInstantiate;

		public GameObject m_EffectPrefab;

		public int m_nEffectFrame;

		public bool m_bEffectOnlyFirst;

		public bool m_bEffectDetach;

		public float m_fEffectSpeed;

		public float m_fEffectScale;

		public Vector3 m_EffectPos;

		public Vector3 m_EffectRot;

		public AudioClip m_AudioClip;

		public int m_nSoundFrame;

		public bool m_bSoundOnlyFirst;

		public bool m_bSoundLoop;

		public float m_fSoundVolume;

		public float m_fSoundPitch;

		public NcSpriteNode GetClone()
		{
			return null;
		}

		public int GetStartFrame()
		{
			return 0;
		}

		public void SetEmpty()
		{
		}

		public bool IsEmptyTexture()
		{
			return false;
		}

		public bool IsUnused()
		{
			return false;
		}
	}

	[SerializeField]
	public enum MESH_TYPE
	{
		BuiltIn_Plane = 0,
		BuiltIn_TwosidePlane = 1
	}

	public enum ALIGN_TYPE
	{
		TOP = 0,
		CENTER = 1,
		BOTTOM = 2
	}

	public enum SPRITE_TYPE
	{
		NcSpriteTexture = 0,
		NcSpriteAnimation = 1
	}

	public enum SHOW_TYPE
	{
		NONE = 0,
		ALL = 1,
		SPRITE = 2,
		ANIMATION = 3,
		EFFECT = 4
	}

	public SPRITE_TYPE m_SpriteType;

	public List<NcSpriteNode> m_SpriteList;

	public int m_nCurrentIndex;

	public int m_nMaxAtlasTextureSize;

	public bool m_bNeedRebuild;

	public int m_nBuildStartIndex;

	public bool m_bTrimBlack;

	public bool m_bTrimAlpha;

	public float m_fUvScale;

	public float m_fTextureRatio;

	public GameObject m_CurrentEffect;

	public NcAttachSound m_CurrentSound;

	protected bool m_bEndSprite;

	public SHOW_TYPE m_ShowType;

	public bool m_bShowEffect;

	public bool m_bTestMode;

	public bool m_bSequenceMode;

	protected bool m_bbInstance;

	public bool IsUnused(int nNodeIndex)
	{
		return false;
	}

	public NcSpriteNode GetSpriteNode(int nIndex)
	{
		return null;
	}

	public NcSpriteNode GetSpriteNode(string spriteName)
	{
		return null;
	}

	public int GetSpriteNodeIndex(string spriteName)
	{
		return 0;
	}

	public NcSpriteNode SetSpriteNode(int nIndex, NcSpriteNode newInfo)
	{
		return null;
	}

	public int AddSpriteNode()
	{
		return 0;
	}

	public int AddSpriteNode(NcSpriteNode addSpriteNode)
	{
		return 0;
	}

	public void DeleteSpriteNode(int nIndex)
	{
	}

	public void MoveSpriteNode(int nSrcIndex, int nTarIndex)
	{
	}

	public void ClearAllSpriteNode()
	{
	}

	public int GetSpriteNodeCount()
	{
		return 0;
	}

	public NcSpriteNode GetCurrentSpriteNode()
	{
		return null;
	}

	public Rect GetSpriteUvRect(int nStriteIndex, int nFrameIndex)
	{
		return default(Rect);
	}

	public bool IsValidFactory()
	{
		return false;
	}

	private void Awake()
	{
	}

	public NcEffectBehaviour SetSprite(int nNodeIndex)
	{
		return null;
	}

	public NcEffectBehaviour SetSprite(string spriteName)
	{
		return null;
	}

	public NcEffectBehaviour SetSprite(int nNodeIndex, bool bRunImmediate)
	{
		return null;
	}

	public int GetCurrentSpriteIndex()
	{
		return 0;
	}

	public bool IsEndSprite()
	{
		return false;
	}

	private void CreateEffectObject()
	{
	}

	public GameObject CreateSpriteEffect(int nSrcSpriteIndex, Transform parentTrans)
	{
		return null;
	}

	private void DestroyEffectObject()
	{
	}

	private void CreateSoundObject(NcSpriteNode ncSpriteNode)
	{
	}

	public void OnChangingSprite(int nOldNodeIndex, int nNewNodeIndex)
	{
	}

	public void OnAnimationStartFrame(NcSpriteAnimation spriteCom)
	{
	}

	public void OnAnimationChangingFrame(NcSpriteAnimation spriteCom, int nOldIndex, int nNewIndex, int nLoopCount)
	{
	}

	public bool OnAnimationLastFrame(NcSpriteAnimation spriteCom, int nLoopCount)
	{
		return false;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public static void CreatePlane(MeshFilter meshFilter, float fUvScale, NcFrameInfo ncSpriteFrameInfo, bool bTrimCenterAlign, ALIGN_TYPE alignType, MESH_TYPE m_MeshType)
	{
	}

	public static void UpdatePlane(MeshFilter meshFilter, float fUvScale, NcFrameInfo ncSpriteFrameInfo, bool bTrimCenterAlign, ALIGN_TYPE alignType)
	{
	}

	public static void UpdateMeshUVs(MeshFilter meshFilter, Rect uv)
	{
	}
}

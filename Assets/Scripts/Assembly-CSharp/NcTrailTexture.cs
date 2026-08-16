using System.Collections.Generic;
using UnityEngine;

public class NcTrailTexture : NcEffectBehaviour
{
	public enum AXIS_TYPE
	{
		AXIS_FORWARD = 0,
		AXIS_BACK = 1,
		AXIS_RIGHT = 2,
		AXIS_LEFT = 3,
		AXIS_UP = 4,
		AXIS_DOWN = 5
	}

	public class Point
	{
		public float timeCreated;

		public Vector3 basePosition;

		public Vector3 tipPosition;

		public bool lineBreak;
	}

	public float m_fDelayTime;

	public float m_fEmitTime;

	public bool m_bSmoothHide;

	protected bool m_bEmit;

	protected float m_fStartTime;

	protected float m_fStopTime;

	public float m_fLifeTime;

	public AXIS_TYPE m_TipAxis;

	public float m_fTipSize;

	public bool m_bCenterAlign;

	public bool m_UvFlipHorizontal;

	public bool m_UvFlipVirtical;

	public int m_nFadeHeadCount;

	public int m_nFadeTailCount;

	public Color[] m_Colors;

	public float[] m_SizeRates;

	public bool m_bInterpolation;

	public int m_nMaxSmoothCount;

	public int m_nSubdivisions;

	protected List<Point> m_SmoothedPoints;

	public float m_fMinVertexDistance;

	public float m_fMaxVertexDistance;

	public float m_fMaxAngle;

	public bool m_bAutoDestruct;

	protected List<Point> m_Points;

	protected Transform m_base;

	protected GameObject m_TrialObject;

	protected Mesh m_TrailMesh;

	protected Vector3 m_LastPosition;

	protected Vector3 m_LastCameraPosition1;

	protected Vector3 m_LastCameraPosition2;

	protected bool m_bLastFrameEmit;

	public void SetEmit(bool bEmit)
	{
	}

	public override int GetAnimationState()
	{
		return 0;
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void InitTrailObject()
	{
	}

	private Vector3 GetTipPoint()
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

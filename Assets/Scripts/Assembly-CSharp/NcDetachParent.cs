using UnityEngine;

public class NcDetachParent : NcEffectBehaviour
{
	public bool m_bFollowParentTransform;

	public bool m_bParentHideToStartDestroy;

	public float m_fSmoothDestroyTime;

	public bool m_bDisableEmit;

	public bool m_bSmoothHide;

	public bool m_bMeshFilterOnlySmoothHide;

	protected bool m_bStartDetach;

	protected float m_fStartDestroyTime;

	protected GameObject m_ParentGameObject;

	protected NcDetachObject m_ncDetachObject;

	protected NcTransformTool m_OriginalPos;

	public void SetDestroyValue(bool bParentHideToStart, bool bStartDisableEmit, float fSmoothDestroyTime, bool bSmoothHide, bool bMeshFilterOnlySmoothHide)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void StartDestroy()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

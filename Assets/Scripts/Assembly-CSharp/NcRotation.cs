using UnityEngine;

public class NcRotation : NcEffectBehaviour
{
	public bool m_bWorldSpace;

	public Vector3 m_vRotationValue;

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

using UnityEngine;

public class NcDetachObject : NcEffectBehaviour
{
	public GameObject m_LinkGameObject;

	public static NcDetachObject Create(GameObject parentObj, GameObject linkObject)
	{
		return null;
	}

	public override void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}
}

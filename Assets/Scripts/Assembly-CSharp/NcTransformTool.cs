using UnityEngine;

public class NcTransformTool
{
	public Vector3 m_vecPos;

	public Quaternion m_vecRot;

	public Vector3 m_vecRotHint;

	public Vector3 m_vecScale;

	public NcTransformTool()
	{
	}

	public NcTransformTool(Transform val)
	{
	}

	public static Vector3 GetZeroVector()
	{
		return default(Vector3);
	}

	public static Vector3 GetUnitVector()
	{
		return default(Vector3);
	}

	public static Quaternion GetIdenQuaternion()
	{
		return default(Quaternion);
	}

	public static void InitLocalTransform(Transform dst)
	{
	}

	public static void InitWorldTransform(Transform dst)
	{
	}

	public static void InitWorldScale(Transform dst)
	{
	}

	public static void CopyLocalTransform(Transform src, Transform dst)
	{
	}

	public static void CopyLossyToLocalScale(Vector3 srcLossyScale, Transform dst)
	{
	}

	public void CopyToLocalTransform(Transform dst)
	{
	}

	public void CopyToTransform(Transform dst)
	{
	}

	public void AddLocalTransform(Transform val)
	{
	}

	public void SetLocalTransform(Transform val)
	{
	}

	public bool IsLocalEquals(Transform val)
	{
		return false;
	}

	public void AddTransform(Transform val)
	{
	}

	public void SetTransform(Transform val)
	{
	}

	public bool IsEquals(Transform val)
	{
		return false;
	}

	public void SetTransform(NcTransformTool val)
	{
	}

	public static float GetTransformScaleMeanValue(Transform srcTrans)
	{
		return 0f;
	}

	public static Vector3 GetTransformScaleMeanVector(Transform srcTrans)
	{
		return default(Vector3);
	}
}

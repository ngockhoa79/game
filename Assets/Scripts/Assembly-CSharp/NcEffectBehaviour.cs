using System.Collections.Generic;
using UnityEngine;

public class NcEffectBehaviour : MonoBehaviour
{
	public class _RuntimeIntance
	{
		public GameObject m_ParentGameObject;

		public GameObject m_ChildGameObject;

		public _RuntimeIntance(GameObject parentGameObject, GameObject childGameObject)
		{
		}
	}

	private static bool m_bShuttingDown;

	private static GameObject m_RootInstance;

	public float m_fUserTag;

	protected MeshFilter m_MeshFilter;

	protected List<Material> m_RuntimeMaterials;

	protected virtual void OnDestroy()
	{
	}

	public static float GetEngineTime()
	{
		return 0f;
	}

	public static float GetEngineDeltaTime()
	{
		return 0f;
	}

	public virtual int GetAnimationState()
	{
		return 0;
	}

	public static GameObject GetRootInstanceEffect()
	{
		return null;
	}

	protected static void SetActive(GameObject target, bool bActive)
	{
	}

	protected static void SetActiveRecursively(GameObject target, bool bActive)
	{
	}

	protected static bool IsActive(GameObject target)
	{
		return false;
	}

	protected static void RemoveAllChildObject(GameObject parent, bool bImmediate)
	{
	}

	public static void HideNcDelayActive(GameObject tarObj)
	{
	}

	public static Texture[] PreloadTexture(GameObject tarObj)
	{
		return null;
	}

	private static Texture[] PreloadTexture(GameObject tarObj, List<GameObject> parentPrefabList)
	{
		return null;
	}

	private static Texture[] PreloadPrefab(GameObject tarObj, List<GameObject> parentPrefabList, bool bCheckDup)
	{
		return null;
	}

	protected void AddRuntimeMaterial(Material addMaterial)
	{
	}

	public static void AdjustSpeedRuntime(GameObject target, float fSpeedRate)
	{
	}

	public static string GetMaterialColorName(Material mat)
	{
		return null;
	}

	protected void DisableEmit()
	{
	}

	public static bool IsSafe()
	{
		return false;
	}

	protected GameObject CreateEditorGameObject(GameObject srcGameObj)
	{
		return null;
	}

	public GameObject CreateGameObject(string name)
	{
		return null;
	}

	public GameObject CreateGameObject(GameObject original)
	{
		return null;
	}

	public GameObject CreateGameObject(GameObject prefabObj, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public GameObject CreateGameObject(GameObject parentObj, GameObject prefabObj)
	{
		return null;
	}

	public GameObject CreateGameObject(GameObject parentObj, Transform parentTrans, GameObject prefabObj)
	{
		return null;
	}

	protected void ChangeParent(Transform newParent, Transform child, bool bKeepingLocalTransform, Transform addTransform)
	{
	}

	protected void UpdateMeshColors(Color color)
	{
	}

	public void OnApplicationQuit()
	{
	}

	public virtual void OnUpdateEffectSpeed(float fSpeedRate, bool bRuntime)
	{
	}

	public virtual void OnUpdateToolData()
	{
	}
}

using System;
using System.Collections.Generic;
using Ice.Client;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
	private int _curPolicyId;

	private BundlePackage _curPolicyBundles;

	private BundlePackage _importantBundles;

	private PoolManager _poolManager;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public GameObject Instance(string bundleName, string loadResourceType)
	{
		UnityEngine.Object prefab = null;
		if (GlobalManager.Instance != null && GlobalManager.Instance.BundleManager != null)
		{
			prefab = GlobalManager.Instance.BundleManager.LoadSpecificResource<UnityEngine.Object>(bundleName, loadResourceType);
		}
		if (prefab == null)
		{
			prefab = Resources.Load(bundleName);
		}
		if (prefab != null)
		{
			GameObject go = UnityEngine.Object.Instantiate(prefab) as GameObject;
			if (go != null)
			{
				go.name = prefab.name;
			}
			return go;
		}
		return null;
	}

	public T Instance<T>(string bundleName, string loadResourceType) where T : UnityEngine.Object
	{
		GameObject go = Instance(bundleName, loadResourceType);
		if (go != null)
		{
			if (typeof(Component).IsAssignableFrom(typeof(T)))
			{
				return go.GetComponent<T>();
			}
			return go as T;
		}
		return null;
	}

	public void Spawn(string bundleName, string loadResourceType, int count = 1)
	{
	}

	public T Instance<T>(string bundleName, string loadResourceType, Vector3 position, Quaternion rotation) where T : UnityEngine.Object
	{
		T obj = Instance<T>(bundleName, loadResourceType);
		if (obj != null)
		{
			if (obj is GameObject go)
			{
				go.transform.position = position;
				go.transform.rotation = rotation;
			}
			else if (obj is Component comp)
			{
				comp.transform.position = position;
				comp.transform.rotation = rotation;
			}
		}
		return obj;
	}

	public void DestroyCosObject(GameObject obj)
	{
		if (obj != null)
		{
			UnityEngine.Object.Destroy(obj);
		}
	}

	public void DestroyCosObjectImmediate(GameObject obj)
	{
		if (obj != null)
		{
			UnityEngine.Object.DestroyImmediate(obj);
		}
	}

	public void CleanPoolManager()
	{
	}

	public void LoadPolicy(int loadPolicyId, Action onCallback = null)
	{
		_curPolicyId = loadPolicyId;
		UnityEngine.Debug.Log($"[RESOURCES] LoadPolicy id={loadPolicyId}");
		onCallback?.Invoke();
	}

	private void LoadPolicyBundleContent(Dictionary<string, List<string>> toLoadList, PreloadPolicyContent.BundleContent bundleContent, BundlePackage bundlePackage)
	{
	}

	private void LoadPolicyBundleContent(Dictionary<string, List<string>> toLoadList, string loadResourceType, string bundlename, bool bLoadAllResources, BundlePackage bundlePackage)
	{
	}
}

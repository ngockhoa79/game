using System.Collections.Generic;
using UnityEngine;

public class PoolManager
{
	private class GameObjectPackage
	{
		private Dictionary<string, GameObjectslist> _gameObjectPackage;

		public int Count => 0;

		public void Spawn(string key, GameObject obj)
		{
		}

		public bool TryPop(string key, out GameObject obj)
		{
			obj = null;
			return false;
		}

		public void Push(string key, GameObject obj)
		{
		}

		public List<GameObject> GetAllGameObjects()
		{
			return null;
		}

		public void ClearAll()
		{
		}
	}

	private class GameObjectslist
	{
		private List<GameObject> gameObjList;

		public int Count => 0;

		public void Push(GameObject obj)
		{
		}

		public GameObject Pop()
		{
			return null;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public List<GameObject> GetAllGameObjects()
		{
			return null;
		}

		public void ClearAll()
		{
		}
	}

	private Vector3 _initPosition;

	private int _increment;

	private GameObject _resourcesRoot;

	private GameObject _recycleRoot;

	private GameObjectPackage _resourcesPackage;

	private GameObjectPackage _recyclePackage;

	private Dictionary<int, string> _instanceId2KeyDic;

	private string GetKey(string loadResourceType, string bundleName)
	{
		return null;
	}

	public void Spawn(string loadResourceType, string bundleName, int count = 1)
	{
	}

	public GameObject Instance(string loadResourceType, string bundleName, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public void Destroy(GameObject go)
	{
	}

	public void DestroyImmediately(GameObject go)
	{
	}

	public void CleanPoolManager()
	{
	}

	private void ActivePoolMember(GameObject go, Vector3 position, Quaternion rotation)
	{
	}

	private void DeactivePoolMember(GameObject go)
	{
	}

	private GameObject __createToScene(string loadResourceType, string bundleName)
	{
		return null;
	}

	private void InitSpawnObject(GameObject go, string loadResourceType, string bundleName)
	{
	}

	private GameObject GetPoolRoot()
	{
		return null;
	}

	private Transform GetResourceRootEntrance()
	{
		return null;
	}

	private Transform GetRecycleRootEntrance()
	{
		return null;
	}
}

using System.Collections.Generic;
using UnityEngine;

public class UIResourceManager
{
	private static Dictionary<string, string> resMapping;

	private static UIResourceManager instance;

	public static UIResourceManager Ins => null;

	private static void initMapping()
	{
	}

	public static void AnalyzeResPath(string res, out string category, out string simpleName)
	{
		category = null;
		simpleName = null;
	}

	public Object Load(string res)
	{
		return null;
	}

	public void Destroy(Object obj, string res)
	{
	}

	public T Load<T>(string res) where T : Object
	{
		return null;
	}

	public GameObject LoadGameObject(string res, Transform parent)
	{
		return null;
	}

	public GameObject LoadGameObject(string res, GameObject parent)
	{
		return null;
	}

	public GameObject LoadGameObject(string res, Component parent)
	{
		return null;
	}

	public T LoadComponent<T>(string res, Transform parent) where T : Component
	{
		return null;
	}

	public T LoadComponent<T>(string res, GameObject parent) where T : Component
	{
		return null;
	}

	public T LoadComponent<T>(string res, Component parent) where T : Component
	{
		return null;
	}

	private UIResourceManager()
	{
	}
}

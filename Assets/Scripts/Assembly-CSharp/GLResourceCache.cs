using System.Collections.Generic;
using Foundation;
using UnityEngine;

public class GLResourceCache
{
	private DuplicationContainerObject _objectCache;

	public void CacheObject(string resType, string name, Object obj)
	{
	}

	public Object TryGetObject(string resType, string name)
	{
		return null;
	}

	public void RemoveExcept(List<Tuple<string, string>> reservelist)
	{
	}

	public void RemoveAll()
	{
	}

	private void RemoveOneCache(string resType, string name)
	{
	}

	private void DebugCurrentCache()
	{
	}
}

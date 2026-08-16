using System.Collections.Generic;
using Foundation;
using UnityEngine;

public class AssetBundlePackage
{
	private Dictionary<string, AssetBundleList> m_mAllAssetBundles;

	public List<Tuple<string, string, float>> GetAllDownloadingProgress()
	{
		return null;
	}

	public bool GetProgress(string bundlename, string loadResourceType, out float progress)
	{
		progress = default(float);
		return false;
	}

	public bool IsLoaded(string bundlename, string loadResourceType)
	{
		return false;
	}

	public bool IsLoading(string bundlename, string loadResourceType)
	{
		return false;
	}

	public AssetBundleState CheckBundleState(string bundlename, string loadResourceType, out AssetBundle assetBundle)
	{
		assetBundle = null;
		return default(AssetBundleState);
	}

	public bool SetBundleLoadingPercent(string bundlename, string loadResourceType, float percent)
	{
		return false;
	}

	public bool LoadComplete(string bundlename, string loadResourceType, AssetBundle assetbundle = null)
	{
		return false;
	}

	public bool Unload(string bundlename, string loadResourceType, bool unloadAll = false)
	{
		return false;
	}

	public static string GetResourceFullDirectory(string loadResourceType)
	{
		return null;
	}

	public List<BundlePackage.OutputBundlePair> ToList()
	{
		return null;
	}

	public static string GetAssetDatabaseFullname(string bundlename, string loadResourceType)
	{
		return null;
	}

	public static string GetResourceFullname(string bundlename, string loadResourceType)
	{
		return null;
	}

	public static string GetBundleFullname(string bundlename, string loadResourceType)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}

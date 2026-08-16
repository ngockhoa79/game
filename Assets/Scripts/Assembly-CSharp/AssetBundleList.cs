using System.Collections.Generic;
using Foundation;
using Ice.Client;
using UnityEngine;

public class AssetBundleList
{
	private class BundleContent
	{
		private int _loadPercent;

		private AssetBundle _assetBundle;

		private bool _bLoadComplete;

		public bool bLoadComplete => false;

		public float Progress => 0f;

		public AssetBundle AssetBundle => null;

		public int LoadPercent => 0;

		public bool SetLoadPercent(int percent)
		{
			return false;
		}

		public bool SetLoadPercent(float percent)
		{
			return false;
		}

		public void LoadComplete(AssetBundle assetbundle)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	private BuildTargetContent _buildConfig;

	private string _loadResourceType;

	private Dictionary<string, BundleContent> m_mBundleDic;

	public int Count => 0;

	public AssetBundleList(string loadResourceType, string languageVersion)
	{
	}

	public AssetBundleState CheckBundleState(string bundlename, out AssetBundle assetBundle)
	{
		assetBundle = null;
		return default(AssetBundleState);
	}

	public bool GetProgress(string bundlename, out float progress)
	{
		progress = default(float);
		return false;
	}

	public bool SetBundleLoadingPercent(string bundlename, float percent)
	{
		return false;
	}

	public bool IsLoaded(string bundlename)
	{
		return false;
	}

	public bool IsLoading(string bundlename)
	{
		return false;
	}

	public bool LoadComplete(string bundlename, AssetBundle assetbundle = null)
	{
		return false;
	}

	public bool Unload(string bundlename, bool unloadAll = false)
	{
		return false;
	}

	public List<BundlePackage.OutputBundlePair> ToList(string loadResourceType)
	{
		return null;
	}

	private BundleContent GetAssetBundleContentByName(string realBundlename)
	{
		return null;
	}

	private string GetRealBundlename(string bundleName)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public List<Tuple<string, float>> GetAllProgress()
	{
		return null;
	}
}

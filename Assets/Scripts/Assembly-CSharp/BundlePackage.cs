using System.Collections.Generic;

public class BundlePackage
{
	private class BundleList
	{
		private List<string> _bundleNames;

		public List<string> BundleNames => null;

		public bool Add(string real_bundlename)
		{
			return false;
		}

		public bool Remove(string real_bundlename)
		{
			return false;
		}
	}

	public class OutputBundlePair
	{
		public string loadResourceType;

		public string bundename;
	}

	private Dictionary<string, BundleList> _bundlePackage;

	public bool Add(string loadResourceType, string bundlename)
	{
		return false;
	}

	public bool Remove(string loadResourceType)
	{
		return false;
	}

	public bool Remove(string loadResourceType, string bundlename)
	{
		return false;
	}

	public bool Contains(string loadResourceType, string bundlename)
	{
		return false;
	}

	public static List<OutputBundlePair> GetDeltaPackage(List<OutputBundlePair> allBundles, List<OutputBundlePair> importantBundles)
	{
		return null;
	}

	private string GetRealBundlename(string loadResourceType, string bundlename)
	{
		return null;
	}

	public void Clear()
	{
	}

	public List<OutputBundlePair> ToList()
	{
		return null;
	}
}

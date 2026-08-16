using System.Collections.Generic;

namespace Ice.Client
{
	public class PreloadPolicyContent
	{
		public enum PreloadPolicyType
		{
			AlwaysInMemory = 1,
			Cleanup = 2,
			OnlyLoad = 3
		}

		public class BundleContent
		{
			public bool bLoadAllResources;

			public string LoadResourceType;

			public string BundleName;
		}

		public PreloadPolicyType PolicyType;

		public int PolicyId;

		public List<BundleContent> BundleList;
	}
}

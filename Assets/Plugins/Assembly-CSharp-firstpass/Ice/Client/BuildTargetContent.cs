namespace Ice.Client
{
	public class BuildTargetContent
	{
		public enum ResourceEnum
		{
			Prefab = 0,
			Scene = 1,
			Music = 2,
			Texture = 3,
			UIAtlas = 4,
			Jpg = 5
		}

		public enum BuildEnum
		{
			OnePrefabOneAB = 0,
			AllPrefabsOneAB = 1
		}

		public string LoadResourceType;

		public ResourceEnum ResourceType;

		public BuildEnum BuildType;

		public string ResourceDirectory;

		public string LanguageVersion;

		public bool PoolManagerReuse;

		public bool IsResources;

		public string TextureImportSettings;

		public int Width;

		public int Height;
	}
}

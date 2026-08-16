public class GLResource
{
	public enum UnloadResourceType
	{
		All = 0,
		Unused = 1,
		UnloadExceptSelfArray = 2,
		ChangeScene = 3,
		OnlyCleanTexture = 4,
		Tiny = 5
	}

	public void CleanResources(UnloadResourceType type = UnloadResourceType.All)
	{
	}
}

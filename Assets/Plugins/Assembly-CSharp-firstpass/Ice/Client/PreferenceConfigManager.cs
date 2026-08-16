namespace Ice.Client
{
	public class PreferenceConfigManager
	{
		private string mParentDirectory;

		private static PreferenceConfigManager instance;

		public CfgBuildTargetDesc BuildTargetDesc;

		public CfgPreloadPolicyDesc PreloadPolicyDesc;

		public CfgGameSettingsDesc GameSettingsDesc;

		public static PreferenceConfigManager Instance()
		{
			return null;
		}

		public bool Initial()
		{
			return false;
		}
	}
}

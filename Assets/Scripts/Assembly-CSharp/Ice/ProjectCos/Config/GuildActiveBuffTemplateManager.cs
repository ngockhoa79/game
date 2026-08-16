using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class GuildActiveBuffTemplateManager : ConfigSingle<GuildActiveBuffTemplateManager, GuildActiveBuffTemplate>
	{
		public GuildActiveBuffTemplate[] Items => null;

		public GuildActiveBuffTemplate GetItemTemplate(int buffid)
		{
			return null;
		}

		public GuildActiveBuffTemplate[] GetGuildsByUnlockLevel(int unlockLevel)
		{
			return null;
		}

		public int GetMaxUnlockLevel()
		{
			return 0;
		}
	}
}

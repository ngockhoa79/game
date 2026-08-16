using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class GuildPartyTemplateManager : ConfigSingle<GuildPartyTemplateManager, GuildPartyTemplate>
	{
		public GuildPartyTemplate[] Items => null;

		public GuildPartyTemplate GetItemTemplate(int id)
		{
			return null;
		}

		public int IndexOf(GuildPartyTemplate t)
		{
			return 0;
		}
	}
}

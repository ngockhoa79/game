using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class GuildConstructionTemplateManager : ConfigSingle<GuildConstructionTemplateManager, GuildDonateTemplate>
	{
		public GuildDonateTemplate[] Items => null;

		public GuildDonateTemplate GetItemTemplate(int id)
		{
			return null;
		}

		public int IndexOf(GuildDonateTemplate t)
		{
			return 0;
		}
	}
}

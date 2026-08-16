using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class GuildActiveBuffTextTemplateManager : ConfigSingle<GuildActiveBuffTextTemplateManager, GuildActiveBuffTextTemplate>
	{
		public GuildActiveBuffTextTemplate[] Items => null;

		public GuildActiveBuffTextTemplate GetItemTemplate(int buffid)
		{
			return null;
		}
	}
}

using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class GuildLevelManager : ConfigSingle<GuildLevelManager, GuildLevelTemplate>
	{
		public GuildLevelTemplate[] Items => null;

		public GuildLevelTemplate GetItemTemplate(int id)
		{
			return null;
		}
	}
}

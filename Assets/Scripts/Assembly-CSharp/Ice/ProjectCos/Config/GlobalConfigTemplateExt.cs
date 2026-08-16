using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Util;

namespace Ice.ProjectCos.Config
{
	public sealed class GlobalConfigTemplateExt : GlobalConfigTemplate
	{
		public DailyTimeRange EscortAdditionTimeRange { get; private set; }

		public override void Init()
		{
		}
	}
}

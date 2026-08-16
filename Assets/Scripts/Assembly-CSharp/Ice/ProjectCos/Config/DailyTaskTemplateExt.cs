using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class DailyTaskTemplateExt : DailyTaskTemplate
	{
		public DailyTaskTextTemplate TextTemplate { get; private set; }

		public override void Init()
		{
		}

		private void DelayInit()
		{
		}
	}
}

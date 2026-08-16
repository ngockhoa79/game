using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class StoryTemplateExt : StoryTemplate
	{
		public new StoryTimingType Timing => default(StoryTimingType);

		public new StoryAction Action => default(StoryAction);

		public new StoryPosition Position => default(StoryPosition);

		public int SpineEnterLine => 0;

		public bool SpineEnterFront => false;

		public new bool HasPlayerName => false;
	}
}

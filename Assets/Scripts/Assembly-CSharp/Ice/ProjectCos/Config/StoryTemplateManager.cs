using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public class StoryTemplateManager : ConfigSingle<StoryTemplateManager, StoryTemplateExt>
	{
		private Dictionary<int, List<StoryTemplateExt>> storyDic;

		public StoryTemplateExt[] GetAllStories()
		{
			return null;
		}

		public List<StoryTemplateExt> GetStory(int _pveId, StoryTimingType _timing, int _rightColumn = -1)
		{
			return null;
		}

		public List<StoryTemplateExt> GetCardStories(int _pveId, StoryTimingType _timing = StoryTimingType.All)
		{
			return null;
		}

		public List<StoryTemplateExt> GetSpineStories(int _pveId, StoryTimingType _timing = StoryTimingType.All)
		{
			return null;
		}

		public bool IsCardAction(StoryAction _action)
		{
			return false;
		}

		public bool IsSpineAction(StoryAction _action)
		{
			return false;
		}
	}
}

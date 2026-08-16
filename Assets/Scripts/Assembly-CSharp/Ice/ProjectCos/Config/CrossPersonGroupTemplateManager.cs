using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class CrossPersonGroupTemplateManager : ConfigSingleExtend<CrossPersonGroupTemplateManager, CrossPersonGroupTemplate>
	{
		private Dictionary<int, int> GroupIDSet;

		private int MinLevel;

		private int MaxLevel;

		public CrossPersonGroupTemplate[] LoadRankingScoreList()
		{
			return null;
		}

		public bool IsLevelValid(int grouplevel)
		{
			return false;
		}

		public CrossPersonGroupTemplate GetGroupTemplate(int groupLevel)
		{
			return null;
		}

		public CrossPersonGroupTemplate[] GetGroupTemplates()
		{
			return null;
		}

		public CrossPersonGroupTemplate GetGroupTemplateByScore(int score)
		{
			return null;
		}

		public int GetLevelByScore(int score)
		{
			return 0;
		}

		public int GetMaxLevel()
		{
			return 0;
		}

		public int GetMinLevel()
		{
			return 0;
		}
	}
}

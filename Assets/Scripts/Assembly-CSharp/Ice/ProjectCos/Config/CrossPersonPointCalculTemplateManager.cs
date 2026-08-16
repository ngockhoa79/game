using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class CrossPersonPointCalculTemplateManager : ConfigSingleExtend<CrossPersonPointCalculTemplateManager, CrossPersonPointCalculTemplate>
	{
		private Dictionary<int, int> GroupIDSet;

		private int MinDiff;

		private int MaxDiff;

		public CrossPersonPointCalculTemplate GetGroupTemplate(int groupDiff)
		{
			return null;
		}

		public int GetTotalPointPreview(int myGroupLevel, int opponentGroupLevel, bool comboWin)
		{
			return 0;
		}

		public int GetMaxDiff()
		{
			return 0;
		}

		public int GetMinDiff()
		{
			return 0;
		}
	}
}

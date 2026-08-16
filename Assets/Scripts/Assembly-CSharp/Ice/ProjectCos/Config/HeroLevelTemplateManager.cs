using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public class HeroLevelTemplateManager : ConfigSingle<HeroLevelTemplateManager, HeroLevelTemplateExt>
	{
		private int[][] expListArray_;

		public HeroLevelTemplateExt[] Items => null;

		private List<int> GetExpList(IEnumerable<int> exps)
		{
			return null;
		}

		public int GetLevelFromTotalExp(int expTotal, int expId)
		{
			return 0;
		}

		public int GetExp(int level, int expId)
		{
			return 0;
		}

		public HeroLevelTemplateExt GetLevelTemplate(int level)
		{
			return null;
		}

		public int GetLvUpNeedExp(int level, int expId)
		{
			return 0;
		}
	}
}

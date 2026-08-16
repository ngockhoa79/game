using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class RefineLevelTemplateManager : ConfigSingleExtend<RefineLevelTemplateManager, RefineLevelTemplate>
	{
		public int GetRefineCoinCost(int refineLevel, ERarity eRarity)
		{
			return 0;
		}

		public int GetRefineStoneCost(int refineLevel)
		{
			return 0;
		}

		public int GetRefineStoneTotal(int refineLevel)
		{
			return 0;
		}
	}
}

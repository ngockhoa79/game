using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class EscortRangeTemplateManager : ConfigSingleExtend<EscortRangeTemplateManager, EscortRangeTemplate>
	{
		private EscortRangeTemplate.RangeOrder GetRangeOrder(int level)
		{
			return null;
		}

		public int GetGoldReward(int level, int carId)
		{
			return 0;
		}
	}
}

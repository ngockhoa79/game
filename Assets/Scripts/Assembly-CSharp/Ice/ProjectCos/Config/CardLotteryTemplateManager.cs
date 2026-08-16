using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class CardLotteryTemplateManager : ConfigSingle<CardLotteryTemplateManager, CardLotteryTemplate>
	{
		public CardLotteryTemplate[] GetItems()
		{
			return null;
		}

		public void GetRandomCardIDs(List<int> outListCardID, int count)
		{
		}
	}
}

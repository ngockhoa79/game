using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public sealed class CardStrengthGassTemplateManager : ConfigSingle<CardStrengthGassTemplateManager, GasTemplateExt>
	{
		public Dictionary<int, List<GasTemplateExt>> gsss_;

		public List<GasTemplateExt> GetGassListByHeroID(int heroID)
		{
			return null;
		}

		public int GetHeroMaxGassLevel(int heroID)
		{
			return 0;
		}

		public GasTemplateExt GetGassTemplateByHeroLevel(int heroID, int level)
		{
			return null;
		}

		public List<GasTemplateExt> GetGassTemplateListByLevel(int heroID, int level)
		{
			return null;
		}
	}
}

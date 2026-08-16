using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class AccSignTemplateManager : ConfigSingleExtend<AccSignTemplateManager, AccumulationSignTemplateExt>
	{
		private Dictionary<int, AccumulationSignTemplateExt> _accSignInfoDic;

		public AccumulationSignTemplateExt[] Items => null;

		public Dictionary<int, AccumulationSignTemplateExt> AccSignInfoDic => null;

		public AccumulationSignTemplateExt GetAccSignInfo(int _day)
		{
			return null;
		}

		public List<ThingHolding> GetAccSignItems(int _month, int _day)
		{
			return null;
		}

		public int GetVipLevel(int _day)
		{
			return 0;
		}

		public int GetVipMultiplier(int _day)
		{
			return 0;
		}
	}
}

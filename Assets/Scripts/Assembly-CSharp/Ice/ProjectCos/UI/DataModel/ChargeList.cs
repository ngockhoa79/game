using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ChargeList
	{
		private List<ChargeInfo> mList;

		private List<ChargeItemN> mListGroup2;

		public List<ChargeInfo> SingleList => null;

		public List<ChargeItemN> DoubleList => null;

		public bool IsFirstCharge { get; private set; }

		public int RestDayForMonthlyUser { get; private set; }

		public List<ThingHolding> FisrtAwards { get; private set; }

		public List<string> FisrtAwardNameKeys { get; private set; }

		public void LoadConfig()
		{
		}

		public ChargeInfo GetChargeInfoByID(int Id)
		{
			return null;
		}

		public void SetChargeInfo(ChargeInfoProto proto)
		{
		}
	}
}

using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ChargeInfo
	{
		private RmbShopTemplate mTmp;

		public int ID => 0;

		public string ProductID => null;

		public string Name => null;

		public string Icon => null;

		public double Price => 0.0;

		public int TypeInt => 0;

		public ChargeType Type { get; private set; }

		public int AwardCsytal => 0;

		public int[] Channels => null;

		public int AwardCsytalExtra => 0;

		public int AwardCsytalExtraFirstBuy => 0;

		public int AwardCsytalExtraNormal => 0;

		public bool IsBoughtBefore { get; set; }

		public ChargeInfo(RmbShopTemplate temp)
		{
		}
	}
}

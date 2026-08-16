using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.DataModel
{
	public class VIP
	{
		private static int sMaxLv;

		public int VipLevel { get; private set; }

		public VIPLevelTemplate Template { get; private set; }

		public int ShopRereshMax => 0;

		public int EnergyRefreshMax => 0;

		public int GoldBuyMax => 0;

		public int ActivityBuyMax => 0;

		public int BuyRobSkill => 0;

		public int BuyTrail => 0;

		public static int MaxVipLevel => 0;

		public int NextVipCharge => 0;

		public int TotalCharge => 0;

		public int CurrentVipInnerCharge => 0;

		public SlotRandom GearStrengthenProbabilities { get; private set; }

		public FixedList<int> GearStrengthenUpgration { get; private set; }

		private VIP(VIPLevelTemplate template)
		{
		}

		public void SetVipLevel(int vipLevel)
		{
		}

		public static VIP Get(int level)
		{
			return null;
		}

		public bool IsMaxVipLevel()
		{
			return false;
		}

		public float GetVipProgress()
		{
			return 0f;
		}
	}
}

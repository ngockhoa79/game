namespace Ice.ProjectCos.UI.DataModel
{
	public class SkillHolding : EquipableItemHolding
	{
		public Skill Skill => null;

		public override int SellingPrice => 0;

		public SkillHolding(Skill skill, int localID, int count = 1)
			: base(null, 0, 0)
		{
		}

		public override void AddToMe()
		{
		}

		private int GetLevelupCostGold()
		{
			return 0;
		}

		private int GetSkillLevelGoldCost(int skillStar)
		{
			return 0;
		}

		private int GetSkillLevelCount(int skillStar)
		{
			return 0;
		}

		private int skillStarLevelupCounts_(int index)
		{
			return 0;
		}

		private int skillStarLevelGoldCosts_(int index)
		{
			return 0;
		}
	}
}

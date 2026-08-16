using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameMath
{
	public static class SkillMath
	{
		public static int[] upgradeSacrificesCount;

		public static int[] upgradeCost;

		public static int GetMaxStar(this Skill skill)
		{
			return 0;
		}

		public static void InitUpgradeArray()
		{
		}

		public static int GetUpgradeSacrificesRequirement(this Skill skill)
		{
			return 0;
		}

		public static int GetUpgradeCost(this Skill skill)
		{
			return 0;
		}

		public static bool CheckUpgradable(this Skill thisSkill)
		{
			return false;
		}

		public static bool CheckNextGradeAvailable(this Skill thisSkill)
		{
			return false;
		}

		public static bool CheckUpgradeMaterialSufficiency(this Skill thisSkill)
		{
			return false;
		}

		public static int GetGoldCost(int skillStarNumber)
		{
			return 0;
		}

		public static int StarupSkillMatCount(int skillStarNumber)
		{
			return 0;
		}
	}
}

using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameMath
{
	public static class GearMath
	{
		private static double[,] factorA;

		private static double factorB;

		private static double factorC;

		private static string[] rarityName;

		private static string[] slotName;

		private static double getFactorA(ERarity rarity, EGearSlot slot)
		{
			return 0.0;
		}

		public static void LoadFromTemplate(GlobalConfigTemplate template)
		{
		}

		public static int GetStrengthenCost(this Gear gear, int level)
		{
			return 0;
		}

		public static int GetStrengthenCost(this GearHolding gear)
		{
			return 0;
		}

		public static int GetStrengthenCost(this GearHolding gear, int level)
		{
			return 0;
		}
	}
}

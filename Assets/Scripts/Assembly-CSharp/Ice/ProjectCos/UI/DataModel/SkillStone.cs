using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class SkillStone : Consumable
	{
		public static SkillStone White { get; private set; }

		public static SkillStone Green { get; private set; }

		public static SkillStone Blue { get; private set; }

		public static SkillStone Purple { get; private set; }

		public static SkillStone Golden { get; private set; }

		public SkillStone(ItemTemplateExt template)
			: base(null)
		{
		}

		public new static void LoadFromTemplate()
		{
		}

		public static bool Is(int configID)
		{
			return false;
		}

		public new static SkillStone Get(int configID)
		{
			return null;
		}

		public static SkillStone FromRarity(ERarity rarity)
		{
			return null;
		}

		public static ERarity ToRarity(SkillStone stone)
		{
			return default(ERarity);
		}

		public static int GetSkillStoneCount(ERarity skillRarity, int star)
		{
			return 0;
		}
	}
}

using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Skill : AbstractItem
	{
		public const int TypeCount = 4;

		public static Dictionary<ESkillType, int> SkillTypeCompareTranslator;

		private int mChipCount;

		private static Dictionary<int, Skill> skills;

		private static Dictionary<int, Skill> groups;

		private readonly List<EHeroProfession> disallowedProfs;

		public SkillTemplateExt Template { get; private set; }

		public override int ID => 0;

		public override string Name => null;

		public override string Desc => null;

		public override string Icon => null;

		public override ERarity Rarity => default(ERarity);

		public override EItemType ItemForm => default(EItemType);

		public int GroupID => 0;

		public ESkillType SkillType => default(ESkillType);

		public int Star => 0;

		public int[] ChipIDs => null;

		public int ChipCount => 0;

		public Skill NextGrade { get; private set; }

		public Skill PrevGrade { get; private set; }

		public static IEnumerable<Skill> Skills => null;

		public static IEnumerable<Skill> Groups => null;

		public IEnumerable<EHeroProfession> DisallowedProfessions => null;

		public int CompareType => 0;

		private Skill(SkillTemplateExt template)
		{
		}

		public static bool Is(int configID)
		{
			return false;
		}

		public static Skill Get(int configID)
		{
			return null;
		}

		public static bool IsGroup(int groupID)
		{
			return false;
		}

		public static Skill GetGroup(int groupID)
		{
			return null;
		}

		public static void LoadFromTemplate()
		{
		}

		private string tr(string str)
		{
			return null;
		}

		public string GetSkillTypeAsString()
		{
			return null;
		}

		public string GetSkillTypeName()
		{
			return null;
		}

		public string GetSkillTypeNameColored()
		{
			return null;
		}

		public override string GetDetailName()
		{
			return null;
		}

		public override string GetDetailNameColored()
		{
			return null;
		}

		public override string GetNameColorTag()
		{
			return null;
		}
	}
}

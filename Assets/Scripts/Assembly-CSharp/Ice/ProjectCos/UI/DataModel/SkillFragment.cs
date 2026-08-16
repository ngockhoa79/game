using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class SkillFragment : MiscItem
	{
		private Skill _target;

		private static Dictionary<int, SkillFragment> fragments;

		public override string Icon => null;

		public override ERarity Rarity => default(ERarity);

		public Skill Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static IEnumerable<SkillFragment> Fragments => null;

		public override EItemType ItemForm => default(EItemType);

		public static bool Is(int configID)
		{
			return false;
		}

		public new static SkillFragment Get(int configID)
		{
			return null;
		}

		private SkillFragment(ItemTemplateExt template)
			: base(null)
		{
		}

		public static void LoadFromTemplates()
		{
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

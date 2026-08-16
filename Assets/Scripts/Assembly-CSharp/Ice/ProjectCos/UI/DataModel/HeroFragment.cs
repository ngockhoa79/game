using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class HeroFragment : MiscItem
	{
		private static Dictionary<int, HeroFragment> fragments;

		public override EItemType ItemForm => default(EItemType);

		public static IEnumerable<HeroFragment> Fragments => null;

		public HeroFragment(ItemTemplateExt template)
			: base(null)
		{
		}

		public static bool Is(int configID)
		{
			return false;
		}

		public new static HeroFragment Get(int configID)
		{
			return null;
		}

		public static void LoadFromTemplate()
		{
		}

		public override string GetDetailName()
		{
			return null;
		}

		public override string GetNameColorTag()
		{
			return null;
		}

		public override string GetDetailNameColored()
		{
			return null;
		}
	}
}

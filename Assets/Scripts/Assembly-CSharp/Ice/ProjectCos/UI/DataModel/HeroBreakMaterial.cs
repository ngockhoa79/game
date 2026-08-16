using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class HeroBreakMaterial : Consumable
	{
		private static Dictionary<int, HeroBreakMaterial> materials;

		private static int MaterialSideMin;

		private static int MaterialSideMax;

		private static int Medicine;

		public override EItemType ItemForm => default(EItemType);

		public static IEnumerable<HeroBreakMaterial> Materials => null;

		public HeroBreakMaterial(ItemTemplateExt template)
			: base(null)
		{
		}

		public static bool Is(int configID)
		{
			return false;
		}

		public new static HeroBreakMaterial Get(int configID)
		{
			return null;
		}

		public new static void LoadFromTemplate()
		{
		}
	}
}

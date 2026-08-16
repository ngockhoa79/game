using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class GearFormula : MiscItem
	{
		private static Dictionary<int, GearFormula> formulas;

		public override string Icon => null;

		public override ERarity Rarity => default(ERarity);

		public Gear Target { get; private set; }

		public int Requirement { get; private set; }

		public override EItemType ItemForm => default(EItemType);

		public static IEnumerable<GearFormula> Formulas => null;

		private GearFormula(ItemTemplateExt template)
			: base(null)
		{
		}

		public static bool Is(int configID)
		{
			return false;
		}

		public new static GearFormula Get(int configID)
		{
			return null;
		}

		public static void LoadFromTemplate()
		{
		}

		public void SetTarget(Gear gear)
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

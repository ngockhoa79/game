using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Consumable : MiscItem
	{
		private static Dictionary<int, Consumable> consumables;

		public override EItemType ItemForm => default(EItemType);

		protected Consumable(ItemTemplateExt template)
			: base(null)
		{
		}

		public static void LoadFromTemplate()
		{
		}

		public static bool IsConsumable<T>(int configID) where T : Consumable
		{
			return false;
		}

		public static bool IsConsumable(int configID)
		{
			return false;
		}

		public new static Consumable Get(int configID)
		{
			return null;
		}

		public bool CanUse()
		{
			return false;
		}
	}
}

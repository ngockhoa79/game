using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class GearStone : Consumable
	{
		public static GearStone Green { get; private set; }

		public static GearStone Blue { get; private set; }

		public static GearStone Purple { get; private set; }

		public static GearStone Golden { get; private set; }

		public static GearStone Red { get; private set; }

		public GearStone(ItemTemplateExt template)
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

		public new static GearStone Get(int configID)
		{
			return null;
		}

		public static GearStone GetByRaity(ERarity r)
		{
			return null;
		}
	}
}

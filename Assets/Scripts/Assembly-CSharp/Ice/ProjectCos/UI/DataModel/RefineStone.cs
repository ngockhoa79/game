using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class RefineStone : Consumable
	{
		public static RefineStone Stones { get; private set; }

		public static RefineStone Green { get; private set; }

		public static RefineStone Blue { get; private set; }

		public static RefineStone Purple { get; private set; }

		public static RefineStone Golden { get; private set; }

		public RefineStone(ItemTemplateExt template)
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

		public new static RefineStone Get(int configID)
		{
			return null;
		}
	}
}

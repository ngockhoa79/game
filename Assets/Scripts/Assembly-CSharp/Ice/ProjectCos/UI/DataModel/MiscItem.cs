using System.Xml;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public class MiscItem : AbstractItem
	{
		public ItemTemplateExt Template { get; protected set; }

		public override int ID => 0;

		public override string Name => null;

		public override string Desc => null;

		public override string Icon => null;

		public override ERarity Rarity => default(ERarity);

		public override EItemType ItemForm => default(EItemType);

		protected MiscItem(ItemTemplateExt template)
		{
		}

		private static bool internalIs<T>(int type) where T : MiscItem
		{
			return false;
		}

		public static bool Is<T>(XmlNode xml) where T : MiscItem
		{
			return false;
		}

		public static bool Is<T>(int configID) where T : MiscItem
		{
			return false;
		}

		public static MiscItem Get(int configID)
		{
			return null;
		}
	}
}

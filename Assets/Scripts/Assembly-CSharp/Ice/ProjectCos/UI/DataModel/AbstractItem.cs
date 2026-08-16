using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class AbstractItem : Thing
	{
		private static readonly Logger logger;

		public abstract ERarity Rarity { get; }

		public DropLevelClient[] DropLevels { get; protected set; }

		public override string GetNameColorTag()
		{
			return null;
		}
	}
}

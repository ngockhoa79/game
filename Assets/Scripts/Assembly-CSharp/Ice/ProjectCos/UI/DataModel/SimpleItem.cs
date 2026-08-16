using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class SimpleItem
	{
		public enum UIType
		{
			Item = 0,
			Skill = 1,
			Gear = 2,
			Hero = 3,
			Current = 4,
			_NUM = 5
		}

		public UIType type;

		public int id;

		public int localId;

		public int count;

		public SimpleItem(ItemChangeProto proto)
		{
		}

		public SimpleItem(ItemHolding holding)
		{
		}

		public SimpleItem(int type, int id, int count)
		{
		}
	}
}

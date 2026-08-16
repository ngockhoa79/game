namespace Ice.ProjectCos.UI.DataModel
{
	public class OpActivityInfo
	{
		private static OpActivityInfo mIns;

		public static OpActivityInfo Instance => null;

		public LimitDrawCardInfo Op_8_LimitDrawCard { get; private set; }

		public BigWhellInfo Op_7_BigWhell { get; private set; }

		public static OpActivityInfo GetInstance()
		{
			return null;
		}

		public static void Release()
		{
		}
	}
}

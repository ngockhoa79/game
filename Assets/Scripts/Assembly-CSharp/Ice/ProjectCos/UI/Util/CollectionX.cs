using System.Collections.Generic;

namespace Ice.ProjectCos.UI.Util
{
	public static class CollectionX
	{
		private static readonly Logger logger;

		public static Value RobustGet<Key, Value>(this Dictionary<Key, Value> dic, Key key, bool assert = true)
		{
			return default(Value);
		}
	}
}

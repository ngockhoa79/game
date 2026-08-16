using System.Collections.Generic;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class LevelupOp : Operation
	{
		public List<int> MaterialCardList;

		public int HeroLocalID { get; private set; }

		public LevelupOp(int heroLocalID, List<int> materials)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}

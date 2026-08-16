using System.Collections.Generic;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildActivityListOp : Operation
	{
		public bool isOK;

		public List<GuildActivityData> items;

		public GuildActivityListOp()
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

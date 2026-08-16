using System.Collections.Generic;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoySupportersOp : Operation
	{
		public bool isOK;

		public List<ColumnInfo> FriendColumn;

		public ConvoySupportersOp()
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

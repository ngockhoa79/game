using System.Collections.Generic;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class BondPositionSetOp : Operation
	{
		private List<int> _PosionIndex;

		private int _CrossType;

		public BondPositionSetOp(List<int> PosionIndex, int CrossType)
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

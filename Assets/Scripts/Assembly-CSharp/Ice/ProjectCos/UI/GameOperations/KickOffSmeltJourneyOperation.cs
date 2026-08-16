using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class KickOffSmeltJourneyOperation : Operation
	{
		public S2CTrialStartBattleAck ACK;

		private bool isManito;

		private int _superIndex;

		private List<int> test;

		public KickOffSmeltJourneyOperation(int superIndex, List<int> test)
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

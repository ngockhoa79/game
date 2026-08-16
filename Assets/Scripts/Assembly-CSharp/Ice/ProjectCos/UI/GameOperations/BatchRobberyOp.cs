using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class BatchRobberyOp : Operation
	{
		public S2CSkillCombineBatchAck ACK;

		private List<int> skillIds;

		public BatchRobberyOp(List<int> skillIds)
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

using System;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CommitArrayOp : Operation
	{
		public BattleArray Array { get; private set; }

		public CommitArrayOp(BattleArray array)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		private bool validateGroupID(BattleArray array)
		{
			return false;
		}

		protected override void ApplyChanges(object response)
		{
		}

		public static void Commit(BattleArray array, Action onSuccessed, Action onFailed, bool forceShow = true)
		{
		}
	}
}

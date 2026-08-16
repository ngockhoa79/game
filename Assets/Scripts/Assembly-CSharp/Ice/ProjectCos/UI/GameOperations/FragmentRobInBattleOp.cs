namespace Ice.ProjectCos.UI.GameOperations
{
	public class FragmentRobInBattleOp : Operation
	{
		private ulong _playerId;

		private int _skillFragmentId;

		public FragmentRobInBattleOp(ulong playerId, int skillFragmentId)
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

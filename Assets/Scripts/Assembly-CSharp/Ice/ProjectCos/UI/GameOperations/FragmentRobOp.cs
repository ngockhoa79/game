using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FragmentRobOp : Operation
	{
		private ulong _playerId;

		private int _skillFragmentId;

		public FragmentRobOp(ulong playerId, int skillFragmentId)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		public static bool AckSuccess(S2CRobberyRobAck.ResultCode _code)
		{
			return false;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}

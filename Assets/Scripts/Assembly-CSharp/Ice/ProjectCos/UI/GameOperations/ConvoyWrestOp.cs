using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyWrestOp : Operation
	{
		private int shipID;

		private int TargetPlayerId;

		private int TargetGuardId;

		public bool isOK { get; private set; }

		public int PunishGoldOfWrestFail { get; private set; }

		public BattleReportProto BattleReport { get; private set; }

		public ConvoyWrestOp(int shipID, int TargetPlayerId, int TargetGuardId)
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

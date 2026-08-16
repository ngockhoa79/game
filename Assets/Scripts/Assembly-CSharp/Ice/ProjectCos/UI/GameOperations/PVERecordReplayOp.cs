using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PVERecordReplayOp : Operation
	{
		public int DuplicateID { get; private set; }

		public C2SDuplicateReportReq.DuplicateType Type { get; private set; }

		public PVERecordReplayOp(int duplicationID, RecordDuplicationType type)
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

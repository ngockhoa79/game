using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class BuyPVEDuplicationTimesOp : Operation
	{
		public bool isOk;

		public int DuplicationId { get; private set; }

		public ChapterType Type { get; private set; }

		public BuyPVEDuplicationTimesOp(int duplicationId, ChapterType type)
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

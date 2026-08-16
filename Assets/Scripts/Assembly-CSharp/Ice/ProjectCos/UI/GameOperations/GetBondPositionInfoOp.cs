namespace Ice.ProjectCos.UI.GameOperations
{
	public class GetBondPositionInfoOp : Operation
	{
		private ulong _PlayerId;

		public GetBondPositionInfoOp(ulong PlayerId)
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

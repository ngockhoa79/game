namespace Ice.ProjectCos.UI.GameOperations
{
	public class BondPositionOpenOp : Operation
	{
		private int _PosionIndex;

		public BondPositionOpenOp(int PosionIndex)
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

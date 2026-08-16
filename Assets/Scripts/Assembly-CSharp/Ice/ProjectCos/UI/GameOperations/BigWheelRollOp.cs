namespace Ice.ProjectCos.UI.GameOperations
{
	public class BigWheelRollOp : Operation
	{
		private bool mIsTen;

		public BigWheelRollOp(bool isTen)
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

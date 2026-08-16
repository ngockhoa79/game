namespace Ice.ProjectCos.UI.GameOperations
{
	public class BuyPVEEnergyOp : Operation
	{
		public bool isOK { get; private set; }

		public BuyPVEEnergyOp()
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

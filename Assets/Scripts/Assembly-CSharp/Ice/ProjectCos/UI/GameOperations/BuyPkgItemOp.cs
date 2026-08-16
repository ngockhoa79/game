using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class BuyPkgItemOp : Operation
	{
		public PkgItem ItemToBuy { get; set; }

		public int BuyCout { get; set; }

		public BuyPkgItemOp(PkgItem itemToBuy, int buyCount = 1)
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

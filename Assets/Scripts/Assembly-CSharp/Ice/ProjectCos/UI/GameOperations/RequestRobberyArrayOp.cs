using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RequestRobberyArrayOp : Operation
	{
		public bool isOK;

		private bool _PurchCard;

		public Player Challenger { get; private set; }

		public RequestRobberyArrayOp(Player challenger, bool PurchCard = false)
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

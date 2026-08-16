using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyLootTargetArrayOp : Operation
	{
		public bool isOK;

		public Player LootTarget { get; private set; }

		public ConvoyLootTargetArrayOp(Player target)
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

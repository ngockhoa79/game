namespace Ice.ProjectCos.UI.GameOperations
{
	public class CardLockOp : Operation
	{
		public bool isOK;

		public int HeroLocalId { get; private set; }

		public bool isLock { get; private set; }

		public CardLockOp(int HeroLocalId, bool isLock)
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

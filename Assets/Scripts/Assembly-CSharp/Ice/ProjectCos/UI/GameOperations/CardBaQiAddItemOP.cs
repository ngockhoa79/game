namespace Ice.ProjectCos.UI.GameOperations
{
	public class CardBaQiAddItemOP : Operation
	{
		public int HeroIndex;

		public int Position;

		public CardBaQiAddItemOP()
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

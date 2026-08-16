namespace Ice.ProjectCos.UI.GameOperations
{
	public class CardBaQiLevelUpOP : Operation
	{
		public int heroID;

		public CardBaQiLevelUpOP()
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

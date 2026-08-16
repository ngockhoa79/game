namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildActiveBuffOp : Operation
	{
		private int _buffId;

		public GuildActiveBuffOp(int buffId)
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

namespace Ice.ProjectCos.UI.GameOperations
{
	public class NurtureCommitOp : Operation
	{
		public int HeroLocalId { get; private set; }

		public NurtureCommitOp(int herolocalId)
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

namespace Ice.ProjectCos.UI.GameOperations
{
	public class WakeupOp : Operation
	{
		public int HeroLocalID { get; private set; }

		public WakeupOp(int heroLocalID)
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

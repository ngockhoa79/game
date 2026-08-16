namespace Ice.ProjectCos.UI.GameOperations
{
	public class CombineOp : Operation
	{
		public int HeroConfigID { get; private set; }

		public CombineOp(int heroConfigID)
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

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ChangePortraOp : Operation
	{
		public int HeroID;

		public bool isOK;

		public ChangePortraOp(int heroID)
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

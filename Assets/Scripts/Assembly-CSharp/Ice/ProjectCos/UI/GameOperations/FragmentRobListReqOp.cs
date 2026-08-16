namespace Ice.ProjectCos.UI.GameOperations
{
	public class FragmentRobListReqOp : Operation
	{
		private int _skillFragment;

		public FragmentRobListReqOp(int skillFragment)
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

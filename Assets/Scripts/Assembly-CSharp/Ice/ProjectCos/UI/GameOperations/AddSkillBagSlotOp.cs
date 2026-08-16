namespace Ice.ProjectCos.UI.GameOperations
{
	public class AddSkillBagSlotOp : Operation
	{
		public bool isOK;

		public AddSkillBagSlotOp()
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

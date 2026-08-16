namespace Ice.ProjectCos.UI.GameOperations
{
	public class SkillFragmentCombineOp : Operation
	{
		private int _skillId;

		public SkillFragmentCombineOp(int skillId)
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

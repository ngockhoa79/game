namespace Ice.ProjectCos.UI.GameOperations
{
	public class UnloadSkillOp : Operation
	{
		public bool isOK;

		private int HeroLocalID;

		private int SkillLocalID;

		public UnloadSkillOp(int HeroLocalID, int SkillLocalID)
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

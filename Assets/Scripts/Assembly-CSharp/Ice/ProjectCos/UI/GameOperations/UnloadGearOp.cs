namespace Ice.ProjectCos.UI.GameOperations
{
	public class UnloadGearOp : Operation
	{
		public bool isOK;

		private int HeroLocalID;

		private int GearLocalID;

		public UnloadGearOp(int HeroLocalID, int GearLocalID)
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

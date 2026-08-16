namespace Ice.ProjectCos.UI.GameOperations
{
	public class ActivityOpenBoxServerNtf : Operation
	{
		public int Postion { get; set; }

		public int LevelID { get; private set; }

		public ActivityOpenBoxServerNtf(int levelID, int position)
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

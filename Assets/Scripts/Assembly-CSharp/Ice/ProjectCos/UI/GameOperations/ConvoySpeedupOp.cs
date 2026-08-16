namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoySpeedupOp : Operation
	{
		public int NewSpeedCode { get; private set; }

		public float NewSpeed { get; private set; }

		public ConvoySpeedupOp()
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

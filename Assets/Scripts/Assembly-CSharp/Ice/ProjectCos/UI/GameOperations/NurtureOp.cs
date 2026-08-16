namespace Ice.ProjectCos.UI.GameOperations
{
	public class NurtureOp : Operation
	{
		public int NurtureType { get; private set; }

		public int HeroLocalId { get; private set; }

		public byte[] Selections1 { get; private set; }

		public byte[] Selections2 { get; private set; }

		public NurtureOp(int nurtureType, int heroLocalId, byte[] S1, byte[] S2)
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

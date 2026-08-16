namespace Ice.ProjectCos.UI.GameOperations
{
	public class RoleSetSignatureOp : Operation
	{
		private string signature;

		public RoleSetSignatureOp(string sign)
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

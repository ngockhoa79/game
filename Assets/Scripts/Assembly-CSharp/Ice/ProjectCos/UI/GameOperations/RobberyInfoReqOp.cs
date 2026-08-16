namespace Ice.ProjectCos.UI.GameOperations
{
	public class RobberyInfoReqOp : Operation
	{
		public enum EType
		{
			Report = 0,
			Notice = 1,
			Rule = 2,
			_NUM = 3
		}

		private EType type;

		public RobberyInfoReqOp(EType type)
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

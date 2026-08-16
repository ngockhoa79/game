using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class DrawCardOp : Operation
	{
		private bool mIsFreeFriendDraw;

		public int MyId { get; set; }

		public C2SHeroLotteryReq.LotteryType Type { get; set; }

		public void SetTypeDrawFriend()
		{
		}

		public void SetTypeDrawByDiamond()
		{
		}

		public void SetTypeDrawByDiamond10()
		{
		}

		public DrawCardOp()
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

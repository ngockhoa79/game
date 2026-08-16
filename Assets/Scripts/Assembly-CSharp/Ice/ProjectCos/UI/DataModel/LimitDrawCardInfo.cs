using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class LimitDrawCardInfo
	{
		public LimitLotteryInfoProto MyInfo { get; set; }

		public int MyRank { get; set; }

		public OpenTime OpenTime { get; set; }

		public int CountScoreToFreeDraw { get; set; }

		public int CostDraw { get; set; }

		public int CostDraw10 { get; set; }

		public List<LimitLotteryInfoProto.RankingInfoProto> AwardPlayers { get; set; }

		public List<int> CardIDCanGet { get; set; }

		public List<int> AwardsRankFromTo { get; private set; }

		public List<List<ThingHolding>> AwardThings { get; private set; }

		public List<string> AwardString { get; private set; }

		public bool IsInFreeCD()
		{
			return false;
		}

		public void SetRankAwards(List<LimitLotteryInfoProto.ConfigProto.RankingReward> list)
		{
		}
	}
}

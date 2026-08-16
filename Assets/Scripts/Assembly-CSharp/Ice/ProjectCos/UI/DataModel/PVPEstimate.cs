namespace Ice.ProjectCos.UI.DataModel
{
	public class PVPEstimate
	{
		public int MineRank;

		public int OpponentRank;

		public string MineName;

		public string OpponentName;

		public int MaxRanking;

		public int Crystal;

		public int Reputation;

		public int MaxRankingDisplay => 0;

		public PVPEstimate(int mine, string mineName, int opponent, string opponentName, int maxRanking, int crystal, int reputation)
		{
		}
	}
}

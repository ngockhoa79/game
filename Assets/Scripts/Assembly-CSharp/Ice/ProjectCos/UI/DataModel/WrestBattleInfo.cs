using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class WrestBattleInfo : DataModelBase
	{
		public enum EWrestStatus
		{
			None = 0,
			Win = 1,
			Lose = 2,
			_NUM = 3
		}

		public Friend Wrestor { get; private set; }

		public bool IsWin { get; private set; }

		public int CarId { get; private set; }

		public int ReportId { get; private set; }

		public long HappenTime { get; private set; }

		public int FailPunish { get; private set; }

		public bool IsAttacker { get; private set; }

		public int HeardIconId { get; set; }

		public void creatFromProto(EscortBattleReportProto.ReporItemProto proto)
		{
		}
	}
}

using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class EscortPlayerInfo : DataModelBase
	{
		public enum CompleteStatus
		{
			None = 0,
			Finished = 1,
			BeWrest = 2,
			_NUM = 3
		}

		public int EscortCount;

		public int EncourageCount;

		public int EncourageValue;

		public CompleteStatus Status;

		public EscortPlayerInfoProto.EscortRecord ScoreBoard;

		public float RunningDistance;

		public int Level { get; private set; }

		public int TotalExp { get; private set; }

		public int WrestCount { get; private set; }

		public string EscortRewardCarName { get; private set; }

		public int EscortRewardRemainGold { get; private set; }

		public Friend WrestPlayer { get; private set; }

		public void createEscortPlayerInfofromProto(EscortPlayerInfoProto proto)
		{
		}
	}
}

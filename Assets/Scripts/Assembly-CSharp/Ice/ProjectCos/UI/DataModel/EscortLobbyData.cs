using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class EscortLobbyData : DataModelBase
	{
		public int Remain;

		public int Extra;

		public int Punish;

		public float Distance;

		public double Speed;

		public float RemainDistance;

		public int SpeedCode;

		public double RealSpeed;

		public int inspireValue;

		public int inspireCount;

		public bool createdByMe;

		public Friend Player { get; private set; }

		public Friend Guard { get; private set; }

		public int CarId { get; private set; }

		public string CarName { get; private set; }

		public int ShipID { get; private set; }

		public int OriginalBaseGold { get; private set; }

		public int OriginalAdditionalGold { get; private set; }

		public void createEscortLobbyInfofromProto(EscortTargetProto proto, int index = 0)
		{
		}
	}
}

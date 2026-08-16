using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.GameOperations;

namespace Ice.ProjectCos.UI.DataModel
{
	public class PVPPlayer : Player
	{
		public long ChallengeCoolDownOverTime;

		public bool Revenge;

		private PVPPlayer(bool revenge)
		{
		}

		public PVPPlayer(Player p)
		{
		}

		public PVPPlayer SetProperties(RequestChallengersOp.PVPOperationData d)
		{
			return null;
		}

		private bool fromProto(RankingerInfoProto proto)
		{
			return false;
		}

		public static PVPPlayer CreateFromProto(RankingerInfoProto proto, bool revenge)
		{
			return null;
		}
	}
}

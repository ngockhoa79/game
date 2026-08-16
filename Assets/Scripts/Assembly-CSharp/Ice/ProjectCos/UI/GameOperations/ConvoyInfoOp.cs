using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyInfoOp : Operation
	{
		public EscortLobbyData Mine;

		public int CourageValue;

		public EscortPlayerInfo Info { get; private set; }

		public List<EscortLobbyData> Players { get; private set; }

		public int SpeedCode { get; private set; }

		public ConvoyInfoOp()
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

using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class BigWhellInfo
	{
		private BigWheelInfoProto mInfo;

		public BigWheelInfoProto RawProto
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OpenTime OpenTime { get; private set; }

		public DateTime NextFreeRollTime { get; private set; }

		public int FreeCount => 0;

		public int RollCost { get; set; }

		public int RollCost_10 => 0;

		public int PoolMoneyTotal { get; set; }

		public void SetNextFreeRollTime(long nextFreeRollTime)
		{
		}

		public bool IsFree()
		{
			return false;
		}
	}
}

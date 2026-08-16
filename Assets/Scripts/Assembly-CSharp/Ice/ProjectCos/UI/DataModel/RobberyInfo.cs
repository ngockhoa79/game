using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class RobberyInfo : DataModelBase
	{
		private AutoRecoveryStruct robberyCount;

		public List<PlayerRobberyInfoProto.ProtectItemProto> ProtectItems;

		public int BuyRobberyCount { get; private set; }

		public int RobberyCount => 0;

		public DateTime LastRefreshTargetTime { get; set; }

		public int MaxRobberyCount => 0;

		public int RobberyIntervalTime => 0;

		public void ReloadFromProto(PlayerRobberyInfoProto robberyInfo)
		{
		}

		public bool RobberyOnce()
		{
			return false;
		}

		public void Sync(int robberyTime)
		{
		}

		public bool CanRobbery()
		{
			return false;
		}

		public float GetTimeLeft()
		{
			return 0f;
		}

		public void CleanBuyRobberyCount()
		{
		}

		public void BuyRobberyCountOnce()
		{
		}
	}
}

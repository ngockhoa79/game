using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class OnlineReward
	{
		private int _progressId;

		private DateTime _receiveTime;

		public void LoadFromProto(OnlineRewardProto onelineReward)
		{
		}

		public void ResetTime()
		{
		}

		public int GetDowncountTime()
		{
			return 0;
		}
	}
}

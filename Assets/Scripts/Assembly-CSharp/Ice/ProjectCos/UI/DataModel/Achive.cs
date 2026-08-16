using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Achive
	{
		public int ID { get; private set; }

		public int ProgressCurValue { get; private set; }

		public int ProgressFinishValue { get; private set; }

		public string ProgressStr { get; private set; }

		public bool IsAchiveComplete { get; set; }

		public bool IsAwardGot { get; private set; }

		public int Type { get; private set; }

		public string Title { get; private set; }

		public string Desc { get; private set; }

		public string Icon { get; private set; }

		public bool IsShowProgress { get; private set; }

		public List<ThingHolding> Rewards { get; private set; }

		public int[] Params { get; private set; }

		public bool CreateFormProto(AchievementItemProto info)
		{
			return false;
		}

		public void ApplyReward()
		{
		}
	}
}

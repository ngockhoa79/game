using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class DailyTask
	{
		public int ID { get; private set; }

		public int ProgressCurValue { get; private set; }

		public int ProgressFinishValue { get; private set; }

		public string ProgressStr { get; private set; }

		public bool IsTaskComplete { get; set; }

		public bool IsAwardGot { get; private set; }

		public string Title { get; private set; }

		public string Desc { get; private set; }

		public string Icon { get; private set; }

		public int UnlockLevel { get; private set; }

		public int RewardExp { get; private set; }

		public List<ThingHolding> Rewards { get; private set; }

		public DropLevelClient DropLevel { get; private set; }

		public DailyTaskTemplate.TaskInfo_ TaskInfo { get; private set; }

		public bool CreateFormProto(TaskItemProto info)
		{
			return false;
		}

		public bool IsTimeType()
		{
			return false;
		}

		public bool IsInTime()
		{
			return false;
		}

		public bool IsPveType()
		{
			return false;
		}

		public void ApplyReward()
		{
		}
	}
}

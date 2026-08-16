using System;

namespace Ice.ProjectCos.Util
{
	public class DailyTimeRange
	{
		public TimeSpan StartTimeSpan { get; private set; }

		public TimeSpan EndTimeSpan { get; private set; }

		public bool IsInRangeNow => false;

		public DailyTimeRange(string timeString, char c = ' ')
		{
		}

		public bool IsInRange(DateTime todayTime)
		{
			return false;
		}
	}
}

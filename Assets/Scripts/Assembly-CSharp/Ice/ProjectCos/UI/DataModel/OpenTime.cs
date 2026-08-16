using System;

namespace Ice.ProjectCos.UI.DataModel
{
	public class OpenTime
	{
		public long mStartTimeSververTick;

		public long mEndTimeSververTick;

		public long StartTimeSververTick
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public DateTime StartTime { get; private set; }

		public long EndTimeSververTick
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public DateTime EndTime { get; private set; }

		public OpenTime()
		{
		}

		public OpenTime(long start, long end)
		{
		}

		public bool IsOpenNow()
		{
			return false;
		}

		public int GetOpenNowState()
		{
			return 0;
		}

		public void SetClose()
		{
		}

		public void SetBeforeOpen()
		{
		}

		public void SetOpen()
		{
		}

		public void SetTime(long start, long end)
		{
		}
	}
}

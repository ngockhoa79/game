using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class AccSignData
	{
		public enum StatusCode
		{
			Uninitialized = 0,
			SignedToday = 1,
			readyToSign = 2
		}

		protected int SignedDays;

		protected long LastReceivedRawTime;

		protected DateTime LastReceivedDateTime;

		protected int[] Days;

		protected int MonthCache;

		public static TimeSpan RefreshTime;

		public static TimeSpan OneSecond;

		public void BuildFromProto(AccumulationSignProto rawProto)
		{
		}

		public void DailyUpdate()
		{
		}

		protected void CrossMonthReset()
		{
		}

		public void Clear()
		{
		}

		public bool Initialized()
		{
			return false;
		}

		public StatusCode GetStatus()
		{
			return default(StatusCode);
		}

		public int GetSignedDays()
		{
			return 0;
		}

		public int GetCurrentYear()
		{
			return 0;
		}

		public int GetCurrentMonth()
		{
			return 0;
		}

		public int GetCurrentYearRightBracket()
		{
			return 0;
		}

		public int GetCurrentMonthRightBracket()
		{
			return 0;
		}

		public int GetCurrentMonthDayCount()
		{
			return 0;
		}
	}
}

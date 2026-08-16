using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public class MyNotificationInfo
	{
		private List<ActivityNoticeContent> _data;

		public List<ActivityNoticeContent> Data => null;

		public void PushNotification(string shortTitle, string title, string content, ActivityNoticeContent.State state)
		{
		}

		public void Clean()
		{
		}
	}
}

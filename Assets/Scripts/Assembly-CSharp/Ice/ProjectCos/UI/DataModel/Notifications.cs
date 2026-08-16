using System;
using Foundation;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Notifications
	{
		public class AnnouncementStruct
		{
			public S2CAnnouncementNtf Data;

			public int Count;

			public AnnouncementStruct(S2CAnnouncementNtf data, int count)
			{
			}
		}

		public Action<S2CAnnouncementNtf> E_OnNewAnnouncement;

		private CircleStruct<AnnouncementStruct> _dataPriority10;

		private CircleStruct<AnnouncementStruct> _dataPriority7to9;

		private CircleStruct<AnnouncementStruct> _dataPriority4to6;

		private CircleStruct<AnnouncementStruct> _dataPriority1to3;

		public void PushNewAnnouncement(S2CAnnouncementNtf ntf)
		{
		}

		public AnnouncementStruct[] GetAnnouncementList()
		{
			return null;
		}

		public AnnouncementStruct[] GeSmeltAnnouncementList()
		{
			return null;
		}

		public AnnouncementStruct[] GeConvoytAnnouncementList()
		{
			return null;
		}

		private CircleStruct<AnnouncementStruct> GetDataByPriority(int priority)
		{
			return null;
		}
	}
}

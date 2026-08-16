using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class FriendNotification : Friend
	{
		public enum FriendMessageState
		{
			ChooseYesOrNo = 0,
			AlreadyAdded = 1,
			AlreadyRefused = 2,
			LeaveMessage = 3,
			SendMessage = 4
		}

		public string Message { get; set; }

		public DateTime MessageTime { get; set; }

		public FriendMessageState State { get; set; }

		public void CreateNotifyFromProto(FriendNoticeProto info)
		{
		}

		public static FriendNotification CreateForMsgSendFriend(Friend f, string msg = "")
		{
			return null;
		}

		public void SetTextByState()
		{
		}
	}
}

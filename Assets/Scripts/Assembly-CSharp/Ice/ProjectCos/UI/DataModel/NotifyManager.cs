using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class NotifyManager
	{
		private static NotifyManager instance;

		private bool mReigsted;

		private bool[] mStatusArr;

		private Dictionary<int, List<Action>> mChangeListeners;

		public static NotifyManager Instance()
		{
			return null;
		}

		private NotifyManager()
		{
		}

		public void Clear()
		{
		}

		private void setStatusAllOff()
		{
		}

		public bool IsNeedNotify(int index)
		{
			return false;
		}

		public void NotifyStatusOff(int index)
		{
		}

		public void NotifyStatus(int index, bool status)
		{
		}

		public void BeginNotifyManager()
		{
		}

		public void RegistListener(int index, Action onChange)
		{
		}

		public void UnRegistListener(int index, Action onChange)
		{
		}

		private void changeNotify(int index)
		{
		}

		private void changeNotify(List<int> changes)
		{
		}

		private bool canNotify(NotifyType type)
		{
			return false;
		}

		private void OnReceiveMsg(object msg, int msgId)
		{
		}

		public void UpdateAllStateFromProto(List<NewNoticeProto> list)
		{
		}

		private void updateState(NewNoticeProto n)
		{
		}

		public static NotifyType ServerTypeToClientType(NewNoticeProto.TypeEnum serverType)
		{
			return default(NotifyType);
		}
	}
}

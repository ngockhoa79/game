using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public class BulletinMessagePool
	{
		protected static int PoolSize;

		public Queue<BulletinMessage> messageQueue;

		public void PushMessage(BulletinMessage new_msg)
		{
		}

		public BulletinMessage PopMessage()
		{
			return null;
		}

		public void BeginReceiveMessage()
		{
		}

		public void EndReceiveMessage()
		{
		}

		public void OnlyUnregistReceiveMessage()
		{
		}

		public void OnReceiveBulletinMsg(object obj, int msgId)
		{
		}

		public BulletinMessage Peek()
		{
			return null;
		}
	}
}

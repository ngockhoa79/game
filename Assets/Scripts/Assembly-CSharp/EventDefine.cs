using MYTOOL.Event;

public class EventDefine
{
	public class InitFinish : IEventMessage
	{
		public static void SendMessage()
		{
		}
	}

	public class LoadRewardVideoEvent : IEventMessage
	{
		public static void SendMessage()
		{
		}
	}
}

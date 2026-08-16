using System;
using System.Threading;

namespace Ice.Project.Utils
{
	public sealed class EventThreadLooper
	{
		private Action<object> handler_;

		private Thread thread_;

		private bool isQuit_;

		private BlockingQueue<object> queue_;

		private int currentThreadId_;

		public bool IsRunInThread => false;

		public EventThreadLooper(Action<object> handler)
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Post(object message)
		{
		}

		private void Run()
		{
		}

		private void OnException(Exception e)
		{
		}
	}
}

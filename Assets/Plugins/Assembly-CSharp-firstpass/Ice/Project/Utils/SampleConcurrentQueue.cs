using System.Collections.Generic;

namespace Ice.Project.Utils
{
	public sealed class SampleConcurrentQueue<T>
	{
		private Queue<T> recvQueue_;

		public void Enqueue(T t)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}
	}
}

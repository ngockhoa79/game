using System.Collections.Generic;

namespace Ice.Project.Utils
{
	public sealed class BlockingQueue<T>
	{
		private Queue<T> queue_;

		private object lock_;

		public T Dequeue()
		{
			return default(T);
		}

		public void Enqueue(T item)
		{
		}
	}
}

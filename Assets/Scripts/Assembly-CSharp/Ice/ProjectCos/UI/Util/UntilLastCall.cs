using System;

namespace Ice.ProjectCos.UI.Util
{
	public class UntilLastCall
	{
		private static Logger logger;

		public readonly Action Action;

		public int TotalCount { get; private set; }

		public int RefCount { get; private set; }

		public int InvocationCount { get; private set; }

		public bool Invoked { get; private set; }

		public UntilLastCall(Action action, int totalCount)
		{
		}

		private void increaseRefCount()
		{
		}

		private void invoke()
		{
		}

		public void Invoke()
		{
		}

		public static implicit operator Action(UntilLastCall obj)
		{
			return null;
		}
	}
}

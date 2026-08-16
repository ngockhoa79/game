namespace Ice.SampleGame.LibClient
{
	internal class StateMachine
	{
		public int State { get; protected set; }

		public virtual int SetStateCheck(int commingEvent, int newState = -1, bool testOnly = false)
		{
			return 0;
		}

		public virtual void SetStateWithoutCheck(int newState)
		{
		}

		public virtual bool EventCheck(int commingEvent)
		{
			return false;
		}
	}
}

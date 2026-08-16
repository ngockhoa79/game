using System.Collections;

namespace Spine36.Unity
{
	public class WaitForSpineAnimationComplete : IEnumerator
	{
		private bool m_WasFired;

		object IEnumerator.Current => null;

		public WaitForSpineAnimationComplete(TrackEntry trackEntry)
		{
		}

		private void HandleComplete(TrackEntry trackEntry)
		{
		}

		private void SafeSubscribe(TrackEntry trackEntry)
		{
		}

		public WaitForSpineAnimationComplete NowWaitFor(TrackEntry trackEntry)
		{
			return null;
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}
}

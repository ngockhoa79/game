using System.Collections;

namespace Spine36.Unity
{
	public class WaitForSpineTrackEntryEnd : IEnumerator
	{
		private bool m_WasFired;

		object IEnumerator.Current => null;

		public WaitForSpineTrackEntryEnd(TrackEntry trackEntry)
		{
		}

		private void HandleEnd(TrackEntry trackEntry)
		{
		}

		private void SafeSubscribe(TrackEntry trackEntry)
		{
		}

		public WaitForSpineTrackEntryEnd NowWaitFor(TrackEntry trackEntry)
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

using System.Collections;

namespace Spine36.Unity
{
	public class WaitForSpineEvent : IEnumerator
	{
		private EventData m_TargetEvent;

		private string m_EventName;

		private AnimationState m_AnimationState;

		private bool m_WasFired;

		private bool m_unsubscribeAfterFiring;

		public bool WillUnsubscribeAfterFiring
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		object IEnumerator.Current => null;

		private void Subscribe(AnimationState state, EventData eventDataReference, bool unsubscribe)
		{
		}

		private void SubscribeByName(AnimationState state, string eventName, bool unsubscribe)
		{
		}

		public WaitForSpineEvent(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true)
		{
		}

		public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, EventData eventDataReference, bool unsubscribeAfterFiring = true)
		{
		}

		public WaitForSpineEvent(AnimationState state, string eventName, bool unsubscribeAfterFiring = true)
		{
		}

		public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring = true)
		{
		}

		private void HandleAnimationStateEventByName(TrackEntry trackEntry, Event e)
		{
		}

		private void HandleAnimationStateEvent(TrackEntry trackEntry, Event e)
		{
		}

		public WaitForSpineEvent NowWaitFor(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true)
		{
			return null;
		}

		public WaitForSpineEvent NowWaitFor(AnimationState state, string eventName, bool unsubscribeAfterFiring = true)
		{
			return null;
		}

		private void Clear(AnimationState state)
		{
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

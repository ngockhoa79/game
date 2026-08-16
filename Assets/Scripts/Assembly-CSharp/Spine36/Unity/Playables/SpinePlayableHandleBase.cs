using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine36.Unity.Playables
{
	public abstract class SpinePlayableHandleBase : MonoBehaviour
	{
		public abstract SkeletonData SkeletonData { get; }

		public abstract Skeleton Skeleton { get; }

		public event SpineEventDelegate AnimationEvents
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual void HandleEvents(ExposedList<Event> eventBuffer)
		{
		}
	}
}

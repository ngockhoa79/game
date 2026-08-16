using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Spine
{
	public class AnimationState
	{
		public delegate void StartEndDelegate(AnimationState state, int trackIndex);

		public delegate void EventDelegate(AnimationState state, int trackIndex, Event e);

		public delegate void CompleteDelegate(AnimationState state, int trackIndex, int loopCount);

		private AnimationStateData data;

		private List<TrackEntry> tracks;

		private List<Event> events;

		private float timeScale;

		public AnimationStateData Data => null;

		public float TimeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event StartEndDelegate Start
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

		public event StartEndDelegate End
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

		public event EventDelegate Event
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

		public event CompleteDelegate Complete
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

		public AnimationState(AnimationStateData data)
		{
		}

		public int GetTracksCount()
		{
			return 0;
		}

		public int GetEventsCount()
		{
			return 0;
		}

		public void Update(float delta)
		{
		}

		public void Apply(Skeleton skeleton)
		{
		}

		public void ClearTracks()
		{
		}

		public void ClearTrack(int trackIndex)
		{
		}

		private TrackEntry ExpandToIndex(int index)
		{
			return null;
		}

		private void SetCurrent(int index, TrackEntry entry)
		{
		}

		public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
		{
			return null;
		}

		public TrackEntry SetAnimation(int trackIndex, Animation animation, bool loop)
		{
			return null;
		}

		public TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
		{
			return null;
		}

		public TrackEntry AddAnimation(int trackIndex, Animation animation, bool loop, float delay)
		{
			return null;
		}

		public TrackEntry GetCurrent(int trackIndex)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

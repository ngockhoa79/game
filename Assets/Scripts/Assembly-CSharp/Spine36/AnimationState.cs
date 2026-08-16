using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Spine36
{
	public class AnimationState
	{
		public delegate void TrackEntryDelegate(TrackEntry trackEntry);

		public delegate void TrackEntryEventDelegate(TrackEntry trackEntry, Event e);

		private static readonly Animation EmptyAnimation;

		internal const int Subsequent = 0;

		internal const int First = 1;

		internal const int Dip = 2;

		internal const int DipMix = 3;

		private AnimationStateData data;

		private Pool<TrackEntry> trackEntryPool;

		private readonly ExposedList<TrackEntry> tracks;

		private readonly ExposedList<Event> events;

		private readonly EventQueue queue;

		private readonly HashSet<int> propertyIDs;

		private readonly ExposedList<TrackEntry> mixingTo;

		private bool animationsChanged;

		private float timeScale;

		public AnimationStateData Data => null;

		public ExposedList<TrackEntry> Tracks => null;

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

		public event TrackEntryDelegate Start
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

		public event TrackEntryDelegate Interrupt
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

		public event TrackEntryDelegate End
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

		public event TrackEntryDelegate Dispose
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

		public event TrackEntryDelegate Complete
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

		public event TrackEntryEventDelegate Event
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

		public void Update(float delta)
		{
		}

		private bool UpdateMixingFrom(TrackEntry to, float delta)
		{
			return false;
		}

		public bool Apply(Skeleton skeleton)
		{
			return false;
		}

		private float ApplyMixingFrom(TrackEntry to, Skeleton skeleton, MixPose currentPose)
		{
			return 0f;
		}

		private static void ApplyRotateTimeline(RotateTimeline rotateTimeline, Skeleton skeleton, float time, float alpha, MixPose pose, float[] timelinesRotation, int i, bool firstFrame)
		{
		}

		private void QueueEvents(TrackEntry entry, float animationTime)
		{
		}

		public void ClearTracks()
		{
		}

		public void ClearTrack(int trackIndex)
		{
		}

		private void SetCurrent(int index, TrackEntry current, bool interrupt)
		{
		}

		public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop, bool Special = false)
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

		public TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration)
		{
			return null;
		}

		public TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay)
		{
			return null;
		}

		public void SetEmptyAnimations(float mixDuration)
		{
		}

		private TrackEntry ExpandToIndex(int index)
		{
			return null;
		}

		private TrackEntry NewTrackEntry(int trackIndex, Animation animation, bool loop, TrackEntry last)
		{
			return null;
		}

		private void DisposeNext(TrackEntry entry)
		{
		}

		private void AnimationsChanged()
		{
		}

		public TrackEntry GetCurrent(int trackIndex)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal void OnStart(TrackEntry entry)
		{
		}

		internal void OnInterrupt(TrackEntry entry)
		{
		}

		internal void OnEnd(TrackEntry entry)
		{
		}

		internal void OnDispose(TrackEntry entry)
		{
		}

		internal void OnComplete(TrackEntry entry)
		{
		}

		internal void OnEvent(TrackEntry entry, Event e)
		{
		}
	}
}

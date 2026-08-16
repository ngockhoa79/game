using System.Runtime.CompilerServices;

namespace Spine
{
	public class TrackEntry
	{
		internal TrackEntry next;

		internal TrackEntry previous;

		internal Animation animation;

		internal bool loop;

		internal float delay;

		internal float time;

		internal float lastTime;

		internal float endTime;

		internal float timeScale;

		internal float mixTime;

		internal float mixDuration;

		internal float mix;

		public Animation Animation => null;

		public float Delay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float LastTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EndTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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

		public float Mix
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event AnimationState.StartEndDelegate Start
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

		public event AnimationState.StartEndDelegate End
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

		public event AnimationState.EventDelegate Event
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

		public event AnimationState.CompleteDelegate Complete
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

		internal void OnStart(AnimationState state, int index)
		{
		}

		internal void OnEnd(AnimationState state, int index)
		{
		}

		internal void OnEvent(AnimationState state, int index, Event e)
		{
		}

		internal void OnComplete(AnimationState state, int index, int loopCount)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}

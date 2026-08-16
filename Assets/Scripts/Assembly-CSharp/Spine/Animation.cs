using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class Animation
	{
		[ProtoMember(1)]
		internal List<Timeline> timelines;

		[ProtoMember(2)]
		internal float duration;

		[ProtoMember(3)]
		internal string name;

		private string[] herosName;

		public int[] timelinesCount;

		public int[] bonesCount;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Timeline> Timelines
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Animation()
		{
		}

		public Animation(string name, List<Timeline> timelines, float duration)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, List<Event> events)
		{
		}

		public void Mix(Skeleton skeleton, float lastTime, float time, bool loop, List<Event> events, float alpha)
		{
		}

		internal static int binarySearch(float[] values, float target, int step)
		{
			return 0;
		}

		internal static int linearSearch(float[] values, float target, int step)
		{
			return 0;
		}
	}
}

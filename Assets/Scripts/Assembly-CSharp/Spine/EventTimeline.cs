using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class EventTimeline : Timeline
	{
		[ProtoMember(1)]
		internal float[] frames;

		[ProtoMember(2)]
		private Event[] events;

		public float[] Frames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Event[] Events
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FrameCount => 0;

		public EventTimeline()
		{
		}

		public EventTimeline(int frameCount)
		{
		}

		public void setFrame(int frameIndex, float time, Event e)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}

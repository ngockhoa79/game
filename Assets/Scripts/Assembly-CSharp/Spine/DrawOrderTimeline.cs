using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class DrawOrderTimeline : Timeline
	{
		[ProtoMember(1)]
		internal float[] frames;

		[ProtoMember(2)]
		private DrawOrderTimelineDate[] drawOrders;

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

		public DrawOrderTimelineDate[] DrawOrders
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

		public DrawOrderTimeline()
		{
		}

		public DrawOrderTimeline(int frameCount)
		{
		}

		public void setFrame(int frameIndex, float time, int[] drawOrder)
		{
		}

		public void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}

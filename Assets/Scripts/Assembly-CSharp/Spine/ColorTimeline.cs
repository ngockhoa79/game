using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class ColorTimeline : CurveTimeline
	{
		protected static int LAST_FRAME_TIME;

		protected static int FRAME_R;

		protected static int FRAME_G;

		protected static int FRAME_B;

		protected static int FRAME_A;

		[ProtoMember(1)]
		internal int slotIndex;

		[ProtoMember(2)]
		internal float[] frames;

		public int SlotIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		public ColorTimeline()
		{
		}

		public ColorTimeline(int frameCount)
		{
		}

		public void setFrame(int frameIndex, float time, float r, float g, float b, float a)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}

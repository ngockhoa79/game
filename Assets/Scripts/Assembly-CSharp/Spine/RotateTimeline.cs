using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class RotateTimeline : CurveTimeline
	{
		protected static int LAST_FRAME_TIME;

		protected static int FRAME_VALUE;

		[ProtoMember(1)]
		internal int boneIndex;

		[ProtoMember(2)]
		internal float[] frames;

		public int BoneIndex
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

		public RotateTimeline()
		{
		}

		public RotateTimeline(int frameCount)
		{
		}

		public void SetFrame(int frameIndex, float time, float angle)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}

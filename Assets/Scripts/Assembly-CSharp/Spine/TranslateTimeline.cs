using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	[ProtoInclude(22, typeof(ScaleTimeline))]
	public class TranslateTimeline : CurveTimeline
	{
		protected static int LAST_FRAME_TIME;

		protected static int FRAME_X;

		protected static int FRAME_Y;

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

		public TranslateTimeline()
		{
		}

		public TranslateTimeline(int frameCount)
		{
		}

		public void SetFrame(int frameIndex, float time, float x, float y)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}

using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	[ProtoInclude(11, typeof(RotateTimeline))]
	[ProtoInclude(12, typeof(TranslateTimeline))]
	[ProtoInclude(14, typeof(ColorTimeline))]
	public abstract class CurveTimeline : Timeline
	{
		protected static float LINEAR;

		protected static float STEPPED;

		protected static int BEZIER_SEGMENTS;

		[ProtoMember(21)]
		private float[] curves;

		public int FrameCount => 0;

		public CurveTimeline()
		{
		}

		public CurveTimeline(int frameCount)
		{
		}

		public abstract void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha);

		public void SetLinear(int frameIndex)
		{
		}

		public void SetStepped(int frameIndex)
		{
		}

		public void SetCurve(int frameIndex, float cx1, float cy1, float cx2, float cy2)
		{
		}

		public float GetCurvePercent(int frameIndex, float percent)
		{
			return 0f;
		}
	}
}

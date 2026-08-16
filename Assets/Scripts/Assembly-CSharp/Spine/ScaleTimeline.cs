using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class ScaleTimeline : TranslateTimeline
	{
		public ScaleTimeline()
		{
		}

		public ScaleTimeline(int frameCount)
		{
		}

		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
		}
	}
}

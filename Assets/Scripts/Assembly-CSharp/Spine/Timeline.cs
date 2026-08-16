using System.Collections.Generic;
using ProtoBuf;

namespace Spine
{
	[ProtoInclude(7, typeof(EventTimeline))]
	[ProtoInclude(1, typeof(CurveTimeline))]
	[ProtoContract]
	[ProtoInclude(8, typeof(DrawOrderTimeline))]
	[ProtoInclude(6, typeof(AttachmentTimeline))]
	public interface Timeline
	{
		void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha);
	}
}

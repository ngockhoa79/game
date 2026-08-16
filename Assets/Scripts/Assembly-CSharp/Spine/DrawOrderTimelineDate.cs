using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public struct DrawOrderTimelineDate
	{
		[ProtoMember(1)]
		public int[] Data;
	}
}

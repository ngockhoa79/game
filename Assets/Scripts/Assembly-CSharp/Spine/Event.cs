using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class Event
	{
		[ProtoMember(1, AsReference = true)]
		public EventData Data { get; private set; }

		[ProtoMember(2)]
		public int Int { get; set; }

		[ProtoMember(3)]
		public float Float { get; set; }

		[ProtoMember(4)]
		public string String { get; set; }

		public Event(EventData data)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}

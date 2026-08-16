using ProtoBuf;

namespace Spine
{
	[ProtoContract]
	public class EventData
	{
		[ProtoMember(1)]
		public string Name { get; private set; }

		[ProtoMember(2)]
		public int Int { get; set; }

		[ProtoMember(3)]
		public float Float { get; set; }

		[ProtoMember(4)]
		public string String { get; set; }

		public EventData(string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}

using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class AnnouncementTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Event_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public Event_ Event;

		[ProtoMember(3)]
		public int LastTime;

		[ProtoMember(4)]
		public int Stay;

		[ProtoMember(5)]
		public int Times;

		[ProtoMember(6)]
		public int Priority;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : AnnouncementTemplate, new()
		{
			return null;
		}

		public static AnnouncementTemplate[] Load()
		{
			return null;
		}
	}
}

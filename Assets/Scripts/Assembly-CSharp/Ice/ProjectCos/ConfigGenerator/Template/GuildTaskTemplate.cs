using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildTaskTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Access : IGeneratorObject
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
		public int TaskType;

		[ProtoMember(3)]
		public Access[] Accesss;

		[ProtoMember(4)]
		public int OnceReward;

		[ProtoMember(5)]
		public int MaxMum;

		[ProtoMember(6)]
		public string TaskIcon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildTaskTemplate, new()
		{
			return null;
		}

		public static GuildTaskTemplate[] Load()
		{
			return null;
		}
	}
}

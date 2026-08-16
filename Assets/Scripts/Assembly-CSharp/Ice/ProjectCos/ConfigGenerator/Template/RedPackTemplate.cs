using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class RedPackTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Drop : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Probability;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Rank;

		[ProtoMember(2)]
		public int Reputation;

		[ProtoMember(3)]
		public int Contribute;

		[ProtoMember(4)]
		public int Crystal;

		[ProtoMember(5)]
		public int Times;

		[ProtoMember(6)]
		public Drop[] Drops;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : RedPackTemplate, new()
		{
			return null;
		}

		public static RedPackTemplate[] Load()
		{
			return null;
		}
	}
}

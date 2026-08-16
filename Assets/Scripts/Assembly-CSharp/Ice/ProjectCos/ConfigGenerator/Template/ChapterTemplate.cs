using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ChapterTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Bonus1 : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Bonus2 : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Bonus3 : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

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
		public int Id;

		[ProtoMember(2)]
		public int OpenLevel;

		[ProtoMember(3)]
		public string Icon;

		[ProtoMember(4)]
		public string BackGround;

		[ProtoMember(5)]
		public string BattleScene;

		[ProtoMember(6)]
		public Bonus1[] Bonus1s;

		[ProtoMember(7)]
		public int Bonus2Star;

		[ProtoMember(8)]
		public Bonus2[] Bonus2s;

		[ProtoMember(9)]
		public int Bonus3Star;

		[ProtoMember(10)]
		public Bonus3[] Bonus3s;

		[ProtoMember(11)]
		public Drop[] Drops;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ChapterTemplate, new()
		{
			return null;
		}

		public static ChapterTemplate[] Load()
		{
			return null;
		}
	}
}

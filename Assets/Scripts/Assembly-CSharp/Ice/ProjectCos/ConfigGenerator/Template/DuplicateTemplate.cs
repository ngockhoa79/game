using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class DuplicateTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class DropIcon : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class DropItem : IGeneratorObject
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

		[ProtoContract]
		public class MustDropItem : IGeneratorObject
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
		public int[] PreIds;

		[ProtoMember(3)]
		public int AreaId;

		[ProtoMember(4)]
		public int ChapterId;

		[ProtoMember(5)]
		public int Index;

		[ProtoMember(6)]
		public int Difficulty;

		[ProtoMember(7)]
		public int Type;

		[ProtoMember(8)]
		public int Task;

		[ProtoMember(9)]
		public int StoryId;

		[ProtoMember(10)]
		public string EnemyName;

		[ProtoMember(11)]
		public int EnemyHead;

		[ProtoMember(12)]
		public int EnemyFormationId;

		[ProtoMember(13)]
		public int Energy;

		[ProtoMember(14)]
		public int LimitTimes;

		[ProtoMember(15)]
		public int Exp;

		[ProtoMember(16)]
		public int Gold;

		[ProtoMember(17)]
		public DropIcon[] DropIcons;

		[ProtoMember(18)]
		public DropItem[] DropItems;

		[ProtoMember(19)]
		public MustDropItem[] MustDropItems;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : DuplicateTemplate, new()
		{
			return null;
		}

		public static DuplicateTemplate[] Load()
		{
			return null;
		}
	}
}

using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ActivityDuplicateTemplate : IGeneratorObject
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
		public class BlankItem : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Number;

			[ProtoMember(4)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class BlankNumber_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int OpenLevel;

		[ProtoMember(3)]
		public int PreId;

		[ProtoMember(4)]
		public int Difficult;

		[ProtoMember(5)]
		public int ChapterIndex;

		[ProtoMember(6)]
		public int Index;

		[ProtoMember(7)]
		public int DropType;

		[ProtoMember(8)]
		public DropIcon[] DropIcons;

		[ProtoMember(9)]
		public string Des;

		[ProtoMember(10)]
		public int StoryId;

		[ProtoMember(11)]
		public int EnemyFormationId;

		[ProtoMember(12)]
		public DropItem[] DropItems;

		[ProtoMember(13)]
		public BlankItem[] BlankItems;

		[ProtoMember(14)]
		public BlankNumber_ BlankNumber;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ActivityDuplicateTemplate, new()
		{
			return null;
		}

		public static ActivityDuplicateTemplate[] Load()
		{
			return null;
		}
	}
}

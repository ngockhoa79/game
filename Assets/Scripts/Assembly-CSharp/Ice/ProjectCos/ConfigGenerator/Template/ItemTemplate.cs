using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ItemTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Statement : IGeneratorObject
		{
			[ProtoMember(1)]
			public int StatementType;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Action : IGeneratorObject
		{
			[ProtoMember(1)]
			public int ActionType;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class DropLevel : IGeneratorObject
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
		public string Name;

		[ProtoMember(3)]
		public string Des;

		[ProtoMember(4)]
		public string Icon;

		[ProtoMember(5)]
		public int Rarity;

		[ProtoMember(6)]
		public int Type;

		[ProtoMember(7)]
		public Statement[] Statements;

		[ProtoMember(8)]
		public Action[] Actions;

		[ProtoMember(9)]
		public DropLevel[] DropLevels;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ItemTemplate, new()
		{
			return null;
		}

		public static ItemTemplate[] Load()
		{
			return null;
		}
	}
}

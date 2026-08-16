using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class DuplicateTaskTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class TaskGoal : IGeneratorObject
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
		public class TaskBonus : IGeneratorObject
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

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public TaskGoal[] TaskGoals;

		[ProtoMember(3)]
		public TaskBonus[] TaskBonuss;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : DuplicateTaskTemplate, new()
		{
			return null;
		}

		public static DuplicateTaskTemplate[] Load()
		{
			return null;
		}
	}
}

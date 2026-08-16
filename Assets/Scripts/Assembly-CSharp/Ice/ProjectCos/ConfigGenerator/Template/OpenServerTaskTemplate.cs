using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class OpenServerTaskTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class TaskInfo_ : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int SignDay;

		[ProtoMember(2)]
		public int Id;

		[ProtoMember(3)]
		public int Type;

		[ProtoMember(4)]
		public TaskInfo_ TaskInfo;

		[ProtoMember(5)]
		public Access[] Accesss;

		[ProtoMember(6)]
		public RewardItem[] RewardItems;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : OpenServerTaskTemplate, new()
		{
			return null;
		}

		public static OpenServerTaskTemplate[] Load()
		{
			return null;
		}
	}
}

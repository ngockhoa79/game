using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class BuffTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Action : IGeneratorObject
		{
			[ProtoMember(1)]
			public int ActionType;

			[ProtoMember(2)]
			public int TriggerOpintType;

			[ProtoMember(3)]
			public int Param1;

			[ProtoMember(4)]
			public int Param2;

			[ProtoMember(5)]
			public int Param3;

			[ProtoMember(6)]
			public int Param4;

			[ProtoMember(7)]
			public int Param5;

			[ProtoMember(8)]
			public int Param6;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int BuffId;

		[ProtoMember(2)]
		public string BuffIcon;

		[ProtoMember(3)]
		public string AddPrefab;

		[ProtoMember(4)]
		public string EffectPrefab;

		[ProtoMember(5)]
		public string LastPrefab;

		[ProtoMember(6)]
		public string RemovePrefab;

		[ProtoMember(7)]
		public int BuffLock;

		[ProtoMember(8)]
		public int LastTime;

		[ProtoMember(9)]
		public Action[] Actions;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : BuffTemplate, new()
		{
			return null;
		}

		public static BuffTemplate[] Load()
		{
			return null;
		}
	}
}

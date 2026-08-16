using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class OpenServerRewardTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class RewardItem_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Number;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int SignDay;

		[ProtoMember(2)]
		public RewardItem_ RewardItem;

		[ProtoMember(3)]
		public string Task1Icon;

		[ProtoMember(4)]
		public string Task2Icon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : OpenServerRewardTemplate, new()
		{
			return null;
		}

		public static OpenServerRewardTemplate[] Load()
		{
			return null;
		}
	}
}

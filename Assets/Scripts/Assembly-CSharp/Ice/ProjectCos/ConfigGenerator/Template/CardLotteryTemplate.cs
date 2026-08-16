using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CardLotteryTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int DropCard;

		[ProtoMember(2)]
		public int DropType;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CardLotteryTemplate, new()
		{
			return null;
		}

		public static CardLotteryTemplate[] Load()
		{
			return null;
		}
	}
}

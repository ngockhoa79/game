using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class BondTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int BondId;

		[ProtoMember(2)]
		public int CardGroupId;

		[ProtoMember(3)]
		public int Type;

		[ProtoMember(4)]
		public int[] BondIds;

		[ProtoMember(5)]
		public int Hp;

		[ProtoMember(6)]
		public int Attack;

		[ProtoMember(7)]
		public int Defense;

		[ProtoMember(8)]
		public int Spirit;

		[ProtoMember(9)]
		public int Speed;

		[ProtoMember(10)]
		public int Critical;

		[ProtoMember(11)]
		public int AntiCritical;

		[ProtoMember(12)]
		public int Batter;

		[ProtoMember(13)]
		public int AntiBatter;

		[ProtoMember(14)]
		public int Miss;

		[ProtoMember(15)]
		public int AntiMiss;

		[ProtoMember(16)]
		public int Block;

		[ProtoMember(17)]
		public int AntiBlock;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : BondTemplate, new()
		{
			return null;
		}

		public static BondTemplate[] Load()
		{
			return null;
		}
	}
}

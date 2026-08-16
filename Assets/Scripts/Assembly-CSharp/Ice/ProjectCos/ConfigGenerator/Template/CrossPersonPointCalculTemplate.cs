using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossPersonPointCalculTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int ID;

		[ProtoMember(2)]
		public int GroupDiffer;

		[ProtoMember(3)]
		public int PushWeight;

		[ProtoMember(4)]
		public int AttackWinPoint;

		[ProtoMember(5)]
		public int AttackLosePoint;

		[ProtoMember(6)]
		public int DefenseWinPoint;

		[ProtoMember(7)]
		public int DefenseLosePoint;

		[ProtoMember(8)]
		public int ContinueAddComboPoint;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossPersonPointCalculTemplate, new()
		{
			return null;
		}

		public static CrossPersonPointCalculTemplate[] Load()
		{
			return null;
		}
	}
}

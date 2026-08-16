using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class BattleShowTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Round;

		[ProtoMember(2)]
		public int Tuneid;

		[ProtoMember(3)]
		public int StateID;

		[ProtoMember(4)]
		public int Action;

		[ProtoMember(5)]
		public int Parameter;

		[ProtoMember(6)]
		public int MainId;

		[ProtoMember(7)]
		public int MainTarget;

		[ProtoMember(8)]
		public int[] Targetss;

		[ProtoMember(9)]
		public int[] Harms;

		[ProtoMember(10)]
		public int[] HpChanges;

		[ProtoMember(11)]
		public int IsCrit;

		[ProtoMember(12)]
		public int SupportId;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : BattleShowTemplate, new()
		{
			return null;
		}

		public static BattleShowTemplate[] Load()
		{
			return null;
		}
	}
}

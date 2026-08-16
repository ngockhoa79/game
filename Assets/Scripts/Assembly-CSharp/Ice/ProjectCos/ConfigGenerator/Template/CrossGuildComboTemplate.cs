using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossGuildComboTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int ContinueCount;

		[ProtoMember(2)]
		public int Bonus;

		[ProtoMember(3)]
		public int Contribute;

		[ProtoMember(4)]
		public double ComboBonusRate;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossGuildComboTemplate, new()
		{
			return null;
		}

		public static CrossGuildComboTemplate[] Load()
		{
			return null;
		}
	}
}

using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class RefineLevelTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public int RefineStone;

		[ProtoMember(3)]
		public int OrangeGold;

		[ProtoMember(4)]
		public int RedGold;

		[ProtoMember(5)]
		public int PurpleGold;

		[ProtoMember(6)]
		public int BlueGold;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : RefineLevelTemplate, new()
		{
			return null;
		}

		public static RefineLevelTemplate[] Load()
		{
			return null;
		}
	}
}

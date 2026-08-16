using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class RefineAdditionValueTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int AdditionId;

		[ProtoMember(3)]
		public int Value;

		[ProtoMember(4)]
		public int Weight;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : RefineAdditionValueTemplate, new()
		{
			return null;
		}

		public static RefineAdditionValueTemplate[] Load()
		{
			return null;
		}
	}
}

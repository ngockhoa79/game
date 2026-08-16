using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EquipTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string Description;

		[ProtoMember(4)]
		public string Action;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EquipTextTemplate, new()
		{
			return null;
		}

		public static EquipTextTemplate[] Load()
		{
			return null;
		}
	}
}

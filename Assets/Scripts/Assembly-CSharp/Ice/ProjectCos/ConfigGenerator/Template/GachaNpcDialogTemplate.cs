using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GachaNpcDialogTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Order;

		[ProtoMember(2)]
		public int CharacterId;

		[ProtoMember(3)]
		public string Dialog;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GachaNpcDialogTemplate, new()
		{
			return null;
		}

		public static GachaNpcDialogTemplate[] Load()
		{
			return null;
		}
	}
}

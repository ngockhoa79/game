using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class TipsTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public string TextId;

		[ProtoMember(2)]
		public string Description;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : TipsTemplate, new()
		{
			return null;
		}

		public static TipsTemplate[] Load()
		{
			return null;
		}
	}
}

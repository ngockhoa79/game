using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class OpenServerTaskTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string TaskDesc;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : OpenServerTaskTextTemplate, new()
		{
			return null;
		}

		public static OpenServerTaskTextTemplate[] Load()
		{
			return null;
		}
	}
}

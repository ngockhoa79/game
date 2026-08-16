using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class UiControlTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public int[] CloseFuctions;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : UiControlTemplate, new()
		{
			return null;
		}

		public static UiControlTemplate[] Load()
		{
			return null;
		}
	}
}

using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossGuildServerGroupTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int ServerGroupID;

		[ProtoMember(2)]
		public int[] ServerIDs;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossGuildServerGroupTemplate, new()
		{
			return null;
		}

		public static CrossGuildServerGroupTemplate[] Load()
		{
			return null;
		}
	}
}

using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossPersonServerGroupTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int ServerGroupID;

		[ProtoMember(2)]
		public int[] ServerIDs;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossPersonServerGroupTemplate, new()
		{
			return null;
		}

		public static CrossPersonServerGroupTemplate[] Load()
		{
			return null;
		}
	}
}

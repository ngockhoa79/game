using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class DailyTaskTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string TaskName;

		[ProtoMember(3)]
		public string DailyTaskDesc;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : DailyTaskTextTemplate, new()
		{
			return null;
		}

		public static DailyTaskTextTemplate[] Load()
		{
			return null;
		}
	}
}

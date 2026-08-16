using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class AchievementTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string AchievementName;

		[ProtoMember(3)]
		public string AchievementTaskDesc;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : AchievementTextTemplate, new()
		{
			return null;
		}

		public static AchievementTextTemplate[] Load()
		{
			return null;
		}
	}
}

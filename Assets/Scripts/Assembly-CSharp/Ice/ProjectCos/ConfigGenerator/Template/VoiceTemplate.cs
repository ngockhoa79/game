using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class VoiceTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int VoiceId;

		[ProtoMember(2)]
		public string NormalAttack1;

		[ProtoMember(3)]
		public string NormalAttack2;

		[ProtoMember(4)]
		public string HeavyAttack;

		[ProtoMember(5)]
		public string SkillAttack;

		[ProtoMember(6)]
		public string Hit;

		[ProtoMember(7)]
		public string HeavyHit;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : VoiceTemplate, new()
		{
			return null;
		}

		public static VoiceTemplate[] Load()
		{
			return null;
		}
	}
}

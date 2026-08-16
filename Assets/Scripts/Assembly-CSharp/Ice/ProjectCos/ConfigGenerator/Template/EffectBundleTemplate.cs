using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EffectBundleTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public string Id;

		[ProtoMember(2)]
		public string FxShowname;

		[ProtoMember(3)]
		public string FxCast;

		[ProtoMember(4)]
		public string FxHit;

		[ProtoMember(5)]
		public string FxLaunch;

		[ProtoMember(6)]
		public string FxHold;

		[ProtoMember(7)]
		public string FxAdd;

		[ProtoMember(8)]
		public string FxLast;

		[ProtoMember(9)]
		public string FxEffect;

		[ProtoMember(10)]
		public string Other1;

		[ProtoMember(11)]
		public string Other2;

		[ProtoMember(12)]
		public string Other3;

		[ProtoMember(13)]
		public string Other4;

		[ProtoMember(14)]
		public string Other5;

		[ProtoMember(15)]
		public string Other6;

		[ProtoMember(16)]
		public string Other7;

		[ProtoMember(17)]
		public string Other8;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EffectBundleTemplate, new()
		{
			return null;
		}

		public static EffectBundleTemplate[] Load()
		{
			return null;
		}
	}
}

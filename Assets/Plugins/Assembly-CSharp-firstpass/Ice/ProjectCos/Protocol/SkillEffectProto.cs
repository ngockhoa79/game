using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "SkillEffectProto")]
	public class SkillEffectProto : IExtensible
	{
		private int _SourceFighterId;

		private int _MainTargetFighterId;

		private int _SkillId;

		private int _SkillUniqueId;

		private List<HarmInfoProto> _Harms;

		private List<BuffAddProto> _BuffAdds;

		private List<BuffActionEffectProto> _OtherBuffEffects;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SourceFighterId", DataFormat = DataFormat.TwosComplement)]
		public int SourceFighterId
		{
			get => _SourceFighterId;
			set => _SourceFighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "MainTargetFighterId", DataFormat = DataFormat.TwosComplement)]
		public int MainTargetFighterId
		{
			get => _MainTargetFighterId;
			set => _MainTargetFighterId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "SkillId", DataFormat = DataFormat.TwosComplement)]
		public int SkillId
		{
			get => _SkillId;
			set => _SkillId = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "SkillUniqueId", DataFormat = DataFormat.TwosComplement)]
		public int SkillUniqueId
		{
			get => _SkillUniqueId;
			set => _SkillUniqueId = value;
		}

		[ProtoMember(5, Name = "Harms", DataFormat = DataFormat.Default)]
		public List<HarmInfoProto> Harms

		{

			get => _Harms;

			set => _Harms = value;

		}

		[ProtoMember(6, Name = "BuffAdds", DataFormat = DataFormat.Default)]
		public List<BuffAddProto> BuffAdds

		{

			get => _BuffAdds;

			set => _BuffAdds = value;

		}

		[ProtoMember(7, Name = "OtherBuffEffects", DataFormat = DataFormat.Default)]
		public List<BuffActionEffectProto> OtherBuffEffects

		{

			get => _OtherBuffEffects;

			set => _OtherBuffEffects = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

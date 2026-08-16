using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SSkillUnEquipReq")]
	public class C2SSkillUnEquipReq : IExtensible
	{
		private int _HeroIndex;

		private int _SkillIndex;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SkillIndex", DataFormat = DataFormat.TwosComplement)]
		public int SkillIndex
		{
			get => _SkillIndex;
			set => _SkillIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.TwosComplement)]
		public int CrossType
		{
			get => _CrossType;
			set => _CrossType = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

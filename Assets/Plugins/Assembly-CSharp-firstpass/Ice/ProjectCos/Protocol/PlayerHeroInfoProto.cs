using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerHeroInfoProto")]
	public class PlayerHeroInfoProto : IExtensible
	{
		private PlayerHeroPropertyInfoProto _PropertyBaseInfo;

		private List<HeroSkillInfoProto> _Skills;

		private List<HeroEquipInfoProto> _Equips;

		private List<int> _Features;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PropertyBaseInfo", DataFormat = DataFormat.Default)]
		public PlayerHeroPropertyInfoProto PropertyBaseInfo
		{
			get => _PropertyBaseInfo;
			set => _PropertyBaseInfo = value;
		}

		[ProtoMember(2, Name = "Skills", DataFormat = DataFormat.Default)]
		public List<HeroSkillInfoProto> Skills

		{

			get => _Skills;

			set => _Skills = value;

		}

		[ProtoMember(3, Name = "Equips", DataFormat = DataFormat.Default)]
		public List<HeroEquipInfoProto> Equips

		{

			get => _Equips;

			set => _Equips = value;

		}

		[ProtoMember(4, Name = "Features", DataFormat = DataFormat.TwosComplement)]
		public List<int> Features

		{

			get => _Features;

			set => _Features = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

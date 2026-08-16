using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerBagInfoProto")]
	public class PlayerBagInfoProto : IExtensible
	{
		private HeroChipContainerProto _HeroChip;

		private EquipmentChipContainerProto _EquipmentDesgin;

		private EquipmentContainerProto _Equipment;

		private SkillChipContainerProto _SkillChip;

		private SkillContainerProto _Skill;

		private ConsumeContainerProto _Consume;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroChip", DataFormat = DataFormat.Default)]
		public HeroChipContainerProto HeroChip
		{
			get => _HeroChip;
			set => _HeroChip = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "EquipmentDesgin", DataFormat = DataFormat.Default)]
		public EquipmentChipContainerProto EquipmentDesgin
		{
			get => _EquipmentDesgin;
			set => _EquipmentDesgin = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Equipment", DataFormat = DataFormat.Default)]
		public EquipmentContainerProto Equipment
		{
			get => _Equipment;
			set => _Equipment = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "SkillChip", DataFormat = DataFormat.Default)]
		public SkillChipContainerProto SkillChip
		{
			get => _SkillChip;
			set => _SkillChip = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Skill", DataFormat = DataFormat.Default)]
		public SkillContainerProto Skill
		{
			get => _Skill;
			set => _Skill = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Consume", DataFormat = DataFormat.Default)]
		public ConsumeContainerProto Consume
		{
			get => _Consume;
			set => _Consume = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

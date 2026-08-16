using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "SellItemProto")]
	public class SellItemProto : IExtensible
	{
		[ProtoContract(Name = "ItemType")]
		public enum ItemType
		{
			[ProtoEnum(Name = "SkillChip", Value = 1)]
			SkillChip = 1,
			[ProtoEnum(Name = "Skill", Value = 2)]
			Skill = 2,
			[ProtoEnum(Name = "EquipmentChip", Value = 3)]
			EquipmentChip = 3,
			[ProtoEnum(Name = "Equipment", Value = 4)]
			Equipment = 4,
			[ProtoEnum(Name = "HeroChip", Value = 5)]
			HeroChip = 5,
			[ProtoEnum(Name = "Consume", Value = 6)]
			Consume = 6,
			[ProtoEnum(Name = "Hero", Value = 7)]
			Hero = 7
		}

		private ItemType _Type;

		private int _Index;

		private int _Count;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public ItemType Type
		{
			get
			{
				return default(ItemType);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

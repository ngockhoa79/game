using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "AnnouncementItemProto")]
	public class AnnouncementItemProto : IExtensible
	{
		[ProtoContract(Name = "ItemType")]
		public enum ItemType
		{
			[ProtoEnum(Name = "None", Value = 0)]
			None = 0,
			[ProtoEnum(Name = "Hero", Value = 1)]
			Hero = 1,
			[ProtoEnum(Name = "Equip", Value = 2)]
			Equip = 2,
			[ProtoEnum(Name = "Skill", Value = 3)]
			Skill = 3,
			[ProtoEnum(Name = "Ship", Value = 4)]
			Ship = 4,
			[ProtoEnum(Name = "Item", Value = 5)]
			Item = 5,
			[ProtoEnum(Name = "BigWheelBigReward", Value = 6)]
			BigWheelBigReward = 6
		}

		private ItemType _Type;

		private int _Id;

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

		[ProtoMember(2, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ItemChangeProto")]
	public class ItemChangeProto : IExtensible
	{
		[ProtoContract(Name = "ItemType")]
		public enum ItemType
		{
			[ProtoEnum(Name = "Hero", Value = 1)]
			Hero = 1,
			[ProtoEnum(Name = "Equip", Value = 2)]
			Equip = 2,
			[ProtoEnum(Name = "Skill", Value = 3)]
			Skill = 3,
			[ProtoEnum(Name = "Item", Value = 4)]
			Item = 4,
			[ProtoEnum(Name = "Resource", Value = 6)]
			Resource = 6
		}

		private ItemType _Type;

		private int _Id;

		private int _Index;

		private int _Count;

		private PlayerHeroInfoProto _HeroInfo;

		private bool _IsFirstObtain;

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

		[ProtoMember(3, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		[ProtoMember(5, IsRequired = false, Name = "HeroInfo", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public PlayerHeroInfoProto HeroInfo
		{
			get => _HeroInfo;
			set => _HeroInfo = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "IsFirstObtain", DataFormat = DataFormat.Default)]
		public bool IsFirstObtain
		{
			get => _IsFirstObtain;
			set => _IsFirstObtain = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

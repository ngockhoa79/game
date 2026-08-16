using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SShopListReq")]
	public class C2SShopListReq : IExtensible
	{
		[ProtoContract(Name = "TypeCode")]
		public enum TypeCode
		{
			[ProtoEnum(Name = "PVEShop1", Value = 2)]
			PVEShop1 = 2,
			[ProtoEnum(Name = "PVEShop2", Value = 3)]
			PVEShop2 = 3,
			[ProtoEnum(Name = "PVEShop3", Value = 4)]
			PVEShop3 = 4,
			[ProtoEnum(Name = "PVPShop", Value = 5)]
			PVPShop = 5,
			[ProtoEnum(Name = "TrialShop", Value = 11)]
			TrialShop = 11,
			[ProtoEnum(Name = "RefineShop", Value = 12)]
			RefineShop = 12,
			[ProtoEnum(Name = "GuildShop", Value = 13)]
			GuildShop = 13,
			[ProtoEnum(Name = "CrossShop", Value = 16)]
			CrossShop = 16
		}

		private TypeCode _Type;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeCode Type
		{
			get
			{
				return default(TypeCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.Default)]
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

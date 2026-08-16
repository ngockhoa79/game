using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SDiamondShopBuyReq")]
	public class C2SDiamondShopBuyReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Item", Value = 0)]
			Item = 0,
			[ProtoEnum(Name = "Gift", Value = 1)]
			Gift = 1
		}

		private TypeEnum _Type;

		private int _Id;

		private int _Count;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
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

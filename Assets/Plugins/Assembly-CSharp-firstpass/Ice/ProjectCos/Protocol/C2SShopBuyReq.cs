using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SShopBuyReq")]
	public class C2SShopBuyReq : IExtensible
	{
		private C2SShopListReq.TypeCode _Type;

		private int _Pos;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SShopListReq.TypeCode Type
		{
			get
			{
				return default(C2SShopListReq.TypeCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Pos", DataFormat = DataFormat.TwosComplement)]
		public int Pos
		{
			get => _Pos;
			set => _Pos = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.Default)]
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

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SShopRefreshReq")]
	public class C2SShopRefreshReq : IExtensible
	{
		private C2SShopListReq.TypeCode _Type;

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

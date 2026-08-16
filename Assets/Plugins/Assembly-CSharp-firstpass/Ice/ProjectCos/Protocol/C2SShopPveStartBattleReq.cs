using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SShopPveStartBattleReq")]
	public class C2SShopPveStartBattleReq : IExtensible
	{
		private C2SShopListReq.TypeCode _Type;

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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

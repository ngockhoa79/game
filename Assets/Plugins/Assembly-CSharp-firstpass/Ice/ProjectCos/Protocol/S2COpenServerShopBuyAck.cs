using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2COpenServerShopBuyAck")]
	public class S2COpenServerShopBuyAck : IExtensible
	{
		private S2CDiamondShopBuyAck.ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public S2CDiamondShopBuyAck.ResultCode Code
		{
			get
			{
				return default(S2CDiamondShopBuyAck.ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

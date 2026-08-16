using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRankingSendRedPacksReq")]
	public class C2SRankingSendRedPacksReq : IExtensible
	{
		private C2SRedPackListReq.TypeEnum _Type;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SRedPackListReq.TypeEnum Type
		{
			get
			{
				return default(C2SRedPackListReq.TypeEnum);
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

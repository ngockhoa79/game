using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SChatListReq")]
	public class C2SChatListReq : IExtensible
	{
		private C2SChatReq.TypeEnum _Type;

		private ulong _LastId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SChatReq.TypeEnum Type
		{
			get
			{
				return default(C2SChatReq.TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "LastId", DataFormat = DataFormat.TwosComplement)]
		public ulong LastId
		{
			get => _LastId;
			set => _LastId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGetBondPositionInfoReq")]
	public class C2SGetBondPositionInfoReq : IExtensible
	{
		private ulong _PlayerId;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong PlayerId
		{
			get => _PlayerId;
			set => _PlayerId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.TwosComplement)]
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

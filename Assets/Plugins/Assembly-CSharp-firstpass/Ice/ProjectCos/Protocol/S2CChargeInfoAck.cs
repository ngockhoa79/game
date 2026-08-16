using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CChargeInfoAck")]
	public class S2CChargeInfoAck : IExtensible
	{
		private ChargeInfoProto _Info;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public ChargeInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

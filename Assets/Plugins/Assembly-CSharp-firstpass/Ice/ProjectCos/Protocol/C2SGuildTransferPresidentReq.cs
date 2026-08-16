using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildTransferPresidentReq")]
	public class C2SGuildTransferPresidentReq : IExtensible
	{
		private ulong _TargetId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TargetId", DataFormat = DataFormat.TwosComplement)]
		public ulong TargetId
		{
			get => _TargetId;
			set => _TargetId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

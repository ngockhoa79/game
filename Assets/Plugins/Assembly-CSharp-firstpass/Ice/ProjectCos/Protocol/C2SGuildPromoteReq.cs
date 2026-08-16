using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildPromoteReq")]
	public class C2SGuildPromoteReq : IExtensible
	{
		private bool _IsPromote;

		private ulong _TargetId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsPromote", DataFormat = DataFormat.Default)]
		public bool IsPromote
		{
			get => _IsPromote;
			set => _IsPromote = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TargetId", DataFormat = DataFormat.TwosComplement)]
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

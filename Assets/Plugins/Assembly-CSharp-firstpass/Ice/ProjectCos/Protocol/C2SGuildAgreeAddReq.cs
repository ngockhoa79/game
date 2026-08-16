using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildAgreeAddReq")]
	public class C2SGuildAgreeAddReq : IExtensible
	{
		private bool _IsAgree;

		private ulong _PlayerId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsAgree", DataFormat = DataFormat.Default)]
		public bool IsAgree
		{
			get => _IsAgree;
			set => _IsAgree = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong PlayerId
		{
			get => _PlayerId;
			set => _PlayerId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

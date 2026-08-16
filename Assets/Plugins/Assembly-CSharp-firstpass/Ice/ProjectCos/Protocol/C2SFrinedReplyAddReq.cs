using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SFrinedReplyAddReq")]
	public class C2SFrinedReplyAddReq : IExtensible
	{
		private ulong _AsckerId;

		private bool _IsAgree;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "AsckerId", DataFormat = DataFormat.TwosComplement)]
		public ulong AsckerId
		{
			get => _AsckerId;
			set => _AsckerId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IsAgree", DataFormat = DataFormat.Default)]
		public bool IsAgree
		{
			get => _IsAgree;
			set => _IsAgree = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

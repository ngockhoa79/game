using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SPresentationFriendReq")]
	public class C2SPresentationFriendReq : IExtensible
	{
		private ulong _FriendId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FriendId", DataFormat = DataFormat.TwosComplement)]
		public ulong FriendId
		{
			get => _FriendId;
			set => _FriendId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

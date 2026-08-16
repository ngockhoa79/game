using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SFriendLeaveMessageReq")]
	public class C2SFriendLeaveMessageReq : IExtensible
	{
		private ulong _FriendId;

		private string _Message;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FriendId", DataFormat = DataFormat.TwosComplement)]
		public ulong FriendId
		{
			get => _FriendId;
			set => _FriendId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Message", DataFormat = DataFormat.Default)]
		public string Message
		{
			get => _Message;
			set => _Message = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

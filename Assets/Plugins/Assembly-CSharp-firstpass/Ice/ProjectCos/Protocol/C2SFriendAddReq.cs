using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SFriendAddReq")]
	public class C2SFriendAddReq : IExtensible
	{
		private List<ulong> _FriendIds;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "FriendIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> FriendIds

		{

			get => _FriendIds;

			set => _FriendIds = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

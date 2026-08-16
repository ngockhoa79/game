using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SFriendPromoteListReq")]
	public class C2SFriendPromoteListReq : IExtensible
	{
		private IExtension extensionObject;

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

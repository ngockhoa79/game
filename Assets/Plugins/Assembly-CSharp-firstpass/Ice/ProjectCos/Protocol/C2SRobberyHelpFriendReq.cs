using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRobberyHelpFriendReq")]
	public class C2SRobberyHelpFriendReq : IExtensible
	{
		private int _FrinedRequestIndex;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FrinedRequestIndex", DataFormat = DataFormat.TwosComplement)]
		public int FrinedRequestIndex
		{
			get => _FrinedRequestIndex;
			set => _FrinedRequestIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

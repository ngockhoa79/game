using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CFriendshipValueNtf")]
	public class S2CFriendshipValueNtf : IExtensible
	{
		private int _FriendshipValue;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FriendshipValue", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipValue
		{
			get => _FriendshipValue;
			set => _FriendshipValue = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

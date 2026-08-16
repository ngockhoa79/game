using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SEscortWrestReq")]
	public class C2SEscortWrestReq : IExtensible
	{
		private int _Id;

		private ulong _TargetPlayerId;

		private ulong _TargetFriendId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TargetPlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong TargetPlayerId
		{
			get => _TargetPlayerId;
			set => _TargetPlayerId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "TargetFriendId", DataFormat = DataFormat.TwosComplement)]
		public ulong TargetFriendId
		{
			get => _TargetFriendId;
			set => _TargetFriendId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

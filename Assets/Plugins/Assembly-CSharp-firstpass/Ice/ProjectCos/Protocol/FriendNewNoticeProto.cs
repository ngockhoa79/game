using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FriendNewNoticeProto")]
	public class FriendNewNoticeProto : IExtensible
	{
		[ProtoContract(Name = "StatusCode")]
		public enum StatusCode
		{
			[ProtoEnum(Name = "AddFriend", Value = 1)]
			AddFriend = 1,
			[ProtoEnum(Name = "EggEnablePick", Value = 2)]
			EggEnablePick = 2,
			[ProtoEnum(Name = "NewNotice", Value = 3)]
			NewNotice = 3
		}

		private StatusCode _Code;

		private PlayerFriendInfoProto _FriendInfo;

		private FriendEggsProto _EggInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public StatusCode Code
		{
			get
			{
				return default(StatusCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "FriendInfo", DataFormat = DataFormat.Default)]
		public PlayerFriendInfoProto FriendInfo
		{
			get => _FriendInfo;
			set => _FriendInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "EggInfo", DataFormat = DataFormat.Default)]
		public FriendEggsProto EggInfo
		{
			get => _EggInfo;
			set => _EggInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

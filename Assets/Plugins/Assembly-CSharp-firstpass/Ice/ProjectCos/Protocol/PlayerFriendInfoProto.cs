using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerFriendInfoProto")]
	public class PlayerFriendInfoProto : IExtensible
	{
		private PlayerSummaryInfoProto _FriendSummaryInfo;

		private int _FriendshipTotal;

		private int _FrinedshipLeve;

		private bool _IsTodayAlreadyPresent;

		private bool _IsPickRewardEnable;

		private bool _IsOnline;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FriendSummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto FriendSummaryInfo
		{
			get => _FriendSummaryInfo;
			set => _FriendSummaryInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "FriendshipTotal", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipTotal
		{
			get => _FriendshipTotal;
			set => _FriendshipTotal = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "FrinedshipLeve", DataFormat = DataFormat.TwosComplement)]
		public int FrinedshipLeve
		{
			get => _FrinedshipLeve;
			set => _FrinedshipLeve = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsTodayAlreadyPresent", DataFormat = DataFormat.Default)]
		public bool IsTodayAlreadyPresent
		{
			get => _IsTodayAlreadyPresent;
			set => _IsTodayAlreadyPresent = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "IsPickRewardEnable", DataFormat = DataFormat.Default)]
		public bool IsPickRewardEnable
		{
			get => _IsPickRewardEnable;
			set => _IsPickRewardEnable = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "IsOnline", DataFormat = DataFormat.Default)]
		public bool IsOnline
		{
			get => _IsOnline;
			set => _IsOnline = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

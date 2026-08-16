using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CPresentationFriendAck")]
	public class S2CPresentationFriendAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "CountIsMax", Value = 2)]
			CountIsMax = 2,
			[ProtoEnum(Name = "FriendIsNoExists", Value = 3)]
			FriendIsNoExists = 3,
			[ProtoEnum(Name = "IsNoPickReward", Value = 4)]
			IsNoPickReward = 4,
			[ProtoEnum(Name = "IsAlreayPresent", Value = 5)]
			IsAlreayPresent = 5,
			[ProtoEnum(Name = "FriendshipIsMax", Value = 6)]
			FriendshipIsMax = 6
		}

		private ResultCode _Code;

		private int _FriendshipTotal;

		private int _FrinedshipLevel;

		private bool _IsPickRewardEnable;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get
			{
				return default(ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "FriendshipTotal", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipTotal
		{
			get => _FriendshipTotal;
			set => _FriendshipTotal = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "FrinedshipLevel", DataFormat = DataFormat.TwosComplement)]
		public int FrinedshipLevel
		{
			get => _FrinedshipLevel;
			set => _FrinedshipLevel = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsPickRewardEnable", DataFormat = DataFormat.Default)]
		public bool IsPickRewardEnable
		{
			get => _IsPickRewardEnable;
			set => _IsPickRewardEnable = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

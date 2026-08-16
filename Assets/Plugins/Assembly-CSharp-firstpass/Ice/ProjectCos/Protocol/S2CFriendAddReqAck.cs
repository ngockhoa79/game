using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CFriendAddReqAck")]
	public class S2CFriendAddReqAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "IsSelfError", Value = 2)]
			IsSelfError = 2,
			[ProtoEnum(Name = "IsAlreayFrinedError", Value = 3)]
			IsAlreayFrinedError = 3,
			[ProtoEnum(Name = "HasNoPlayerError", Value = 4)]
			HasNoPlayerError = 4,
			[ProtoEnum(Name = "TargetFriendCountIsMax", Value = 5)]
			TargetFriendCountIsMax = 5,
			[ProtoEnum(Name = "AddFriendIsInCD", Value = 6)]
			AddFriendIsInCD = 6
		}

		private ResultCode _Code;

		private int _AddSuccessCount;

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

		[ProtoMember(2, IsRequired = true, Name = "AddSuccessCount", DataFormat = DataFormat.TwosComplement)]
		public int AddSuccessCount
		{
			get => _AddSuccessCount;
			set => _AddSuccessCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

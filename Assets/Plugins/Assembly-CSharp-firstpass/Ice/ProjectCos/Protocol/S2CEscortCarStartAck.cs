using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortCarStartAck")]
	public class S2CEscortCarStartAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoInTime", Value = 2)]
			NoInTime = 2,
			[ProtoEnum(Name = "NoRefreshCar", Value = 3)]
			NoRefreshCar = 3,
			[ProtoEnum(Name = "IsRunning", Value = 4)]
			IsRunning = 4,
			[ProtoEnum(Name = "FriendIdError", Value = 5)]
			FriendIdError = 5,
			[ProtoEnum(Name = "FriendAlreadyUsed", Value = 6)]
			FriendAlreadyUsed = 6
		}

		private ResultCode _Code;

		private EscortTargetProto _TargetCarInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "TargetCarInfo", DataFormat = DataFormat.Default)]
		public EscortTargetProto TargetCarInfo
		{
			get => _TargetCarInfo;
			set => _TargetCarInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

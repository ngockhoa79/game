using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CWeekVipGiftInfoAck")]
	public class S2CWeekVipGiftInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotOpen", Value = 2)]
			NotOpen = 2
		}

		private ResultCode _Code;

		private WeekVipGiftInfoProto _Info;

		private WeekVipGiftInfoProto.ConfigProto _ConfigInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public WeekVipGiftInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ConfigInfo", DataFormat = DataFormat.Default)]
		public WeekVipGiftInfoProto.ConfigProto ConfigInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

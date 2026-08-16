using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CLimitLotteryInfoAck")]
	public class S2CLimitLotteryInfoAck : IExtensible
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

		private LimitLotteryInfoProto.ConfigProto _ConfigInfo;

		private LimitLotteryInfoProto _Info;

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

		[ProtoMember(2, IsRequired = true, Name = "ConfigInfo", DataFormat = DataFormat.Default)]
		public LimitLotteryInfoProto.ConfigProto ConfigInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public LimitLotteryInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

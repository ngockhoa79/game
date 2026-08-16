using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CChatAck")]
	public class S2CChatAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "WorldChatCD", Value = 2)]
			WorldChatCD = 2,
			[ProtoEnum(Name = "ChatMessageTooLong", Value = 3)]
			ChatMessageTooLong = 3,
			[ProtoEnum(Name = "WorldTimesNotEnough", Value = 4)]
			WorldTimesNotEnough = 4,
			[ProtoEnum(Name = "ChatBlock", Value = 5)]
			ChatBlock = 5,
			[ProtoEnum(Name = "MoneyLess", Value = 6)]
			MoneyLess = 6,
			[ProtoEnum(Name = "NoGuild", Value = 7)]
			NoGuild = 7
		}

		private ResultCode _Code;

		private long _WorldChatCDOverTime;

		private int _WorldChatEnableTimes;

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

		[ProtoMember(2, IsRequired = true, Name = "WorldChatCDOverTime", DataFormat = DataFormat.TwosComplement)]
		public long WorldChatCDOverTime
		{
			get => _WorldChatCDOverTime;
			set => _WorldChatCDOverTime = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "WorldChatEnableTimes", DataFormat = DataFormat.TwosComplement)]
		public int WorldChatEnableTimes
		{
			get => _WorldChatEnableTimes;
			set => _WorldChatEnableTimes = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

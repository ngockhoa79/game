using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildActiveBuffAck")]
	public class S2CGuildActiveBuffAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoGuild", Value = 2)]
			NoGuild = 2,
			[ProtoEnum(Name = "GuldLevelLess", Value = 3)]
			GuldLevelLess = 3,
			[ProtoEnum(Name = "IsFull", Value = 4)]
			IsFull = 4,
			[ProtoEnum(Name = "BuffIdError", Value = 5)]
			BuffIdError = 5,
			[ProtoEnum(Name = "MoneyLess", Value = 6)]
			MoneyLess = 6,
			[ProtoEnum(Name = "ContributionLess", Value = 7)]
			ContributionLess = 7
		}

		private ResultCode _Code;

		private PlayerGuildInfoProto _InfoOfPlayer;

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

		[ProtoMember(2, IsRequired = true, Name = "InfoOfPlayer", DataFormat = DataFormat.Default)]
		public PlayerGuildInfoProto InfoOfPlayer
		{
			get => _InfoOfPlayer;
			set => _InfoOfPlayer = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

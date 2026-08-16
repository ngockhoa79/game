using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossGuildForamtionInfoAck")]
	public class S2CCrossGuildForamtionInfoAck : IExtensible
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
			GuldLevelLess = 3
		}

		private ResultCode _Code;

		private CrossGuildFormationProto _Foramtion;

		private CrossGuildBattleOverPlayerRewardProto _BattleOverInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "Foramtion", DataFormat = DataFormat.Default)]
		public CrossGuildFormationProto Foramtion
		{
			get => _Foramtion;
			set => _Foramtion = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BattleOverInfo", DataFormat = DataFormat.Default)]
		public CrossGuildBattleOverPlayerRewardProto BattleOverInfo
		{
			get => _BattleOverInfo;
			set => _BattleOverInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

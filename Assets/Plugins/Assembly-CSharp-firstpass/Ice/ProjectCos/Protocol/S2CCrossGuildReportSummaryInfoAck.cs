using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossGuildReportSummaryInfoAck")]
	public class S2CCrossGuildReportSummaryInfoAck : IExtensible
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
			[ProtoEnum(Name = "NoBattle", Value = 4)]
			NoBattle = 4
		}

		private ResultCode _Code;

		private CrossGuildBattleReportSummaryProto _Info;

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
		public CrossGuildBattleReportSummaryProto Info
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

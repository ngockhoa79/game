using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonPlayOffBattleReportAck")]
	public class S2CCrossPersonPlayOffBattleReportAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotOpen", Value = 2)]
			NotOpen = 2,
			[ProtoEnum(Name = "LevelLess", Value = 3)]
			LevelLess = 3,
			[ProtoEnum(Name = "IndexError", Value = 4)]
			IndexError = 4
		}

		private ResultCode _Code;

		private CrossPersonPlayOffBattleReportProto _ReportInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "ReportInfo", DataFormat = DataFormat.Default)]
		public CrossPersonPlayOffBattleReportProto ReportInfo
		{
			get => _ReportInfo;
			set => _ReportInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

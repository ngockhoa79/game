using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRankIngBattleReportAck")]
	public class S2CRankIngBattleReportAck : IExtensible
	{
		[ProtoContract(Name = "CodeResult")]
		public enum CodeResult
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private CodeResult _Code;

		private RankingBattleReportProto _ReportInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public CodeResult Code
		{
			get
			{
				return default(CodeResult);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "ReportInfo", DataFormat = DataFormat.Default)]
		public RankingBattleReportProto ReportInfo
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

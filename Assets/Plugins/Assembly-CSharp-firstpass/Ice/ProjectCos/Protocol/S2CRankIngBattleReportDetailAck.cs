using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRankIngBattleReportDetailAck")]
	public class S2CRankIngBattleReportDetailAck : IExtensible
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

		private BattleReportProto _BattleReport;

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

		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public BattleReportProto BattleReport
		{
			get => _BattleReport;
			set => _BattleReport = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

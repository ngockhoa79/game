using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateReportProto")]
	public class DuplicateReportProto : IExtensible
	{
		private PlayerSummaryInfoProto _PlayerSummaryInfo;

		private BattleReportProto _BattleReport;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerSummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto PlayerSummaryInfo
		{
			get => _PlayerSummaryInfo;
			set => _PlayerSummaryInfo = value;
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

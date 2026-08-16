using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerBattleReportProto")]
	public class PlayerBattleReportProto : IExtensible
	{
		private PlayerSummaryInfoProto _Summary;

		private BattleReportProto _BattleReport;

		private long _Time;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Summary", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto Summary
		{
			get => _Summary;
			set => _Summary = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public BattleReportProto BattleReport
		{
			get => _BattleReport;
			set => _BattleReport = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public long Time
		{
			get => _Time;
			set => _Time = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

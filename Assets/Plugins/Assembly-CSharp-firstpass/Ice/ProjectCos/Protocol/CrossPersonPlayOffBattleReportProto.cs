using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPersonPlayOffBattleReportProto")]
	public class CrossPersonPlayOffBattleReportProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ReportItemProto")]
		public class ReportItemProto : IExtensible
		{
			private CrossPlayerSummaryInfoProto _Winner;

			private CrossPlayerSummaryInfoProto _Loser;

			private BattleReportProto _Report;

			private long _Time;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Winner", DataFormat = DataFormat.Default)]
			public CrossPlayerSummaryInfoProto Winner
			{
				get => _Winner;
				set => _Winner = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Loser", DataFormat = DataFormat.Default)]
			public CrossPlayerSummaryInfoProto Loser
			{
				get => _Loser;
				set => _Loser = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Report", DataFormat = DataFormat.Default)]
			public BattleReportProto Report
			{
				get => _Report;
				set => _Report = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
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

		private List<ReportItemProto> _Reports;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Reports", DataFormat = DataFormat.Default)]
		public List<ReportItemProto> Reports

		{

			get => _Reports;

			set => _Reports = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

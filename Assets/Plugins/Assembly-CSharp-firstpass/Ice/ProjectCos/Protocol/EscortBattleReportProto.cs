using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EscortBattleReportProto")]
	public class EscortBattleReportProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ReporItemProto")]
		public class ReporItemProto : IExtensible
		{
			private int _ReportId;

			private PlayerSummaryInfoProto _SummaryInfo;

			private bool _IsWin;

			private int _CarId;

			private long _Time;

			private int _WrestFailPunish;

			private bool _IsAttacker;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "ReportId", DataFormat = DataFormat.TwosComplement)]
			public int ReportId
			{
				get => _ReportId;
				set => _ReportId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto SummaryInfo
			{
				get => _SummaryInfo;
				set => _SummaryInfo = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "IsWin", DataFormat = DataFormat.Default)]
			public bool IsWin
			{
				get => _IsWin;
				set => _IsWin = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "CarId", DataFormat = DataFormat.TwosComplement)]
			public int CarId
			{
				get => _CarId;
				set => _CarId = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "WrestFailPunish", DataFormat = DataFormat.TwosComplement)]
			public int WrestFailPunish
			{
				get => _WrestFailPunish;
				set => _WrestFailPunish = value;
			}

			[ProtoMember(7, IsRequired = true, Name = "IsAttacker", DataFormat = DataFormat.Default)]
			public bool IsAttacker
			{
				get => _IsAttacker;
				set => _IsAttacker = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<ReporItemProto> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ReporItemProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

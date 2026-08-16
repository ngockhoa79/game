using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CDuplicateBattleAck")]
	public class S2CDuplicateBattleAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "TimesLess", Value = 2)]
			TimesLess = 2,
			[ProtoEnum(Name = "PrevDuplicateIsNotOpen", Value = 3)]
			PrevDuplicateIsNotOpen = 3,
			[ProtoEnum(Name = "EnergyLess", Value = 4)]
			EnergyLess = 4,
			[ProtoEnum(Name = "SweepNotMaxStar", Value = 5)]
			SweepNotMaxStar = 5,
			[ProtoEnum(Name = "RemailSweepCountLess", Value = 6)]
			RemailSweepCountLess = 6,
			[ProtoEnum(Name = "SweepMoneyLess", Value = 7)]
			SweepMoneyLess = 7
		}

		private ResultCode _Code;

		private BattleReportProto _BattleReport;

		private List<DuplicateSettlementProto> _Settlements;

		private bool _IsAlreadyChallanged;

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

		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public BattleReportProto BattleReport
		{
			get => _BattleReport;
			set => _BattleReport = value;
		}

		[ProtoMember(3, Name = "Settlements", DataFormat = DataFormat.Default)]
		public List<DuplicateSettlementProto> Settlements

		{

			get => _Settlements;

			set => _Settlements = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "IsAlreadyChallanged", DataFormat = DataFormat.Default)]
		public bool IsAlreadyChallanged
		{
			get => _IsAlreadyChallanged;
			set => _IsAlreadyChallanged = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

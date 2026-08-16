using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortWrestAck")]
	public class S2CEscortWrestAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoInTime", Value = 2)]
			NoInTime = 2,
			[ProtoEnum(Name = "TimesLess", Value = 3)]
			TimesLess = 3,
			[ProtoEnum(Name = "IsRunning", Value = 4)]
			IsRunning = 4,
			[ProtoEnum(Name = "FriendIdError", Value = 5)]
			FriendIdError = 5,
			[ProtoEnum(Name = "FriendAlreadyUsed", Value = 6)]
			FriendAlreadyUsed = 6,
			[ProtoEnum(Name = "TargetIsSelf", Value = 7)]
			TargetIsSelf = 7,
			[ProtoEnum(Name = "MoneyLess", Value = 8)]
			MoneyLess = 8,
			[ProtoEnum(Name = "CarNotFound", Value = 9)]
			CarNotFound = 9,
			[ProtoEnum(Name = "CarMasterIdIsError", Value = 10)]
			CarMasterIdIsError = 10
		}

		private ResultCode _Code;

		private BattleReportProto _BattleReport;

		private int _PuishGoldOfWrestFail;

		private EscortCarInfoProto _CarInfoIfSuccess;

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

		[ProtoMember(3, IsRequired = true, Name = "PuishGoldOfWrestFail", DataFormat = DataFormat.TwosComplement)]
		public int PuishGoldOfWrestFail
		{
			get => _PuishGoldOfWrestFail;
			set => _PuishGoldOfWrestFail = value;
		}

		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "CarInfoIfSuccess", DataFormat = DataFormat.Default)]
		public EscortCarInfoProto CarInfoIfSuccess
		{
			get => _CarInfoIfSuccess;
			set => _CarInfoIfSuccess = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

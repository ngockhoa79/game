using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRobberyRobAck")]
	public class S2CRobberyRobAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "ChipIdError", Value = 1)]
			ChipIdError = 1,
			[ProtoEnum(Name = "ChipAnyExistsErrror", Value = -2)]
			ChipAnyExistsErrror = -2,
			[ProtoEnum(Name = "CountIsNotEnough", Value = 2)]
			CountIsNotEnough = 2,
			[ProtoEnum(Name = "TargetTimesLess", Value = -1)]
			TargetTimesLess = -1,
			[ProtoEnum(Name = "BattleFail", Value = 3)]
			BattleFail = 3,
			[ProtoEnum(Name = "RobberyFail", Value = 4)]
			RobberyFail = 4,
			[ProtoEnum(Name = "Success", Value = 5)]
			Success = 5,
			[ProtoEnum(Name = "SuccessButUsed", Value = 6)]
			SuccessButUsed = 6
		}

		private ResultCode _Code;

		private BattleReportProto _BattleReport;

		private List<ItemChangeProto> _Changes;

		private int _RobberyCount;

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

		[ProtoMember(3, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "RobberyCount", DataFormat = DataFormat.TwosComplement)]
		public int RobberyCount
		{
			get => _RobberyCount;
			set => _RobberyCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

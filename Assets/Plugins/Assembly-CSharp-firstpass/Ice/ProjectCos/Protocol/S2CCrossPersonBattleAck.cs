using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonBattleAck")]
	public class S2CCrossPersonBattleAck : IExtensible
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
			[ProtoEnum(Name = "TargetIdError", Value = 4)]
			TargetIdError = 4,
			[ProtoEnum(Name = "BattleCounrMax", Value = 5)]
			BattleCounrMax = 5
		}

		private ResultCode _Code;

		private BattleReportProto _ReportProto;

		private PlayerCrossPersonInfoProto _Info;

		private int _ScoreChange;

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

		[ProtoMember(2, IsRequired = true, Name = "ReportProto", DataFormat = DataFormat.Default)]
		public BattleReportProto ReportProto
		{
			get => _ReportProto;
			set => _ReportProto = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public PlayerCrossPersonInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ScoreChange", DataFormat = DataFormat.TwosComplement)]
		public int ScoreChange
		{
			get => _ScoreChange;
			set => _ScoreChange = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

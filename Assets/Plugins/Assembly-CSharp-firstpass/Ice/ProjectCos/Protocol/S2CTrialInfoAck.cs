using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CTrialInfoAck")]
	public class S2CTrialInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private TrialInfoProto _TrialInfo;

		private List<TrialForamtionProto> _StageFinish;

		private List<TrialForamtionProto> _SuperStageFinish;

		private int _BuyRefreshStrangerTimes;

		private TrialRecordProto _RecordInfo;

		private bool _IsRecordExists;

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

		[ProtoMember(2, IsRequired = true, Name = "TrialInfo", DataFormat = DataFormat.Default)]
		public TrialInfoProto TrialInfo
		{
			get => _TrialInfo;
			set => _TrialInfo = value;
		}

		[ProtoMember(3, Name = "StageFinish", DataFormat = DataFormat.Default)]
		public List<TrialForamtionProto> StageFinish

		{

			get => _StageFinish;

			set => _StageFinish = value;

		}

		[ProtoMember(4, Name = "SuperStageFinish", DataFormat = DataFormat.Default)]
		public List<TrialForamtionProto> SuperStageFinish

		{

			get => _SuperStageFinish;

			set => _SuperStageFinish = value;

		}

		[ProtoMember(5, IsRequired = true, Name = "BuyRefreshStrangerTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyRefreshStrangerTimes
		{
			get => _BuyRefreshStrangerTimes;
			set => _BuyRefreshStrangerTimes = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "RecordInfo", DataFormat = DataFormat.Default)]
		public TrialRecordProto RecordInfo
		{
			get => _RecordInfo;
			set => _RecordInfo = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "IsRecordExists", DataFormat = DataFormat.Default)]
		public bool IsRecordExists
		{
			get => _IsRecordExists;
			set => _IsRecordExists = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

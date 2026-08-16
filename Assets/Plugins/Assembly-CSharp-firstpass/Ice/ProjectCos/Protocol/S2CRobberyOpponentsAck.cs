using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRobberyOpponentsAck")]
	public class S2CRobberyOpponentsAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "TargetInfoProto")]
		public class TargetInfoProto : IExtensible
		{
			private PlayerSummaryInfoProto _SummaryInfo;

			private ProbabilityType _Probability;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto SummaryInfo
			{
				get => _SummaryInfo;
				set => _SummaryInfo = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Probability", DataFormat = DataFormat.TwosComplement)]
			public ProbabilityType Probability
			{
				get
				{
					return default(ProbabilityType);
				}
				set
				{
				}
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "ProbabilityType")]
		public enum ProbabilityType
		{
			[ProtoEnum(Name = "Low", Value = 0)]
			Low = 0,
			[ProtoEnum(Name = "Normal", Value = 1)]
			Normal = 1,
			[ProtoEnum(Name = "High", Value = 2)]
			High = 2
		}

		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "ChipIdError", Value = 2)]
			ChipIdError = 2
		}

		private ResultCode _Code;

		private int _skillChipId;

		private List<TargetInfoProto> _Targets;

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

		[ProtoMember(2, IsRequired = true, Name = "skillChipId", DataFormat = DataFormat.TwosComplement)]
		public int SkillChipId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[ProtoMember(3, Name = "Targets", DataFormat = DataFormat.Default)]
		public List<TargetInfoProto> Targets

		{

			get => _Targets;

			set => _Targets = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

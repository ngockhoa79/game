using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RobberyReportInfoListProto")]
	public class RobberyReportInfoListProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "TargetInfo")]
		public class TargetInfo : IExtensible
		{
			private int _Id;

			private TypeEnum _Type;

			private PlayerSummaryInfoProto _Targeter;

			private int _SkillChipId;

			private long _Time;

			private StatusCode _Status;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
			public TypeEnum Type
			{
				get
				{
					return default(TypeEnum);
				}
				set
				{
				}
			}

			[ProtoMember(3, IsRequired = true, Name = "Targeter", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Targeter
			{
				get => _Targeter;
				set => _Targeter = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "SkillChipId", DataFormat = DataFormat.TwosComplement)]
			public int SkillChipId
			{
				get => _SkillChipId;
				set => _SkillChipId = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
			public StatusCode Status
			{
				get
				{
					return default(StatusCode);
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

		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Robbery", Value = 0)]
			Robbery = 0,
			[ProtoEnum(Name = "BeRobbery", Value = 1)]
			BeRobbery = 1,
			[ProtoEnum(Name = "Revenge", Value = 2)]
			Revenge = 2,
			[ProtoEnum(Name = "BeRevenge", Value = 3)]
			BeRevenge = 3,
			[ProtoEnum(Name = "Help", Value = 4)]
			Help = 4,
			[ProtoEnum(Name = "BeHelp", Value = 5)]
			BeHelp = 5
		}

		[ProtoContract(Name = "StatusCode")]
		public enum StatusCode
		{
			[ProtoEnum(Name = "Success", Value = 0)]
			Success = 0,
			[ProtoEnum(Name = "BattleFail", Value = 1)]
			BattleFail = 1,
			[ProtoEnum(Name = "RobberyFail", Value = 2)]
			RobberyFail = 2,
			[ProtoEnum(Name = "SuccessButUsed", Value = 3)]
			SuccessButUsed = 3
		}

		private List<TargetInfo> _Reports;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Reports", DataFormat = DataFormat.Default)]
		public List<TargetInfo> Reports

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

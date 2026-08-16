using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonBattleReportAck")]
	public class S2CCrossPersonBattleReportAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ReportItemProto")]
		public class ReportItemProto : IExtensible
		{
			private CrossPlayerSummaryInfoProto _summary;

			private bool _IsWin;

			private long _Time;

			private int _Score;

			private bool _IsAttack;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "summary", DataFormat = DataFormat.Default)]
			public CrossPlayerSummaryInfoProto Summary
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			[ProtoMember(2, IsRequired = true, Name = "IsWin", DataFormat = DataFormat.Default)]
			public bool IsWin
			{
				get => _IsWin;
				set => _IsWin = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
			public int Score
			{
				get => _Score;
				set => _Score = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "IsAttack", DataFormat = DataFormat.Default)]
			public bool IsAttack
			{
				get => _IsAttack;
				set => _IsAttack = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

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
			LevelLess = 3
		}

		private ResultCode _Code;

		private List<ReportItemProto> _Reports;

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

		[ProtoMember(2, Name = "Reports", DataFormat = DataFormat.Default)]
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

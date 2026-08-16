using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TrialBattleReporProto")]
	public class TrialBattleReporProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ReporItemProto")]
		public class ReporItemProto : IExtensible
		{
			private PlayerSummaryInfoProto _SummaryInfo;

			private bool _IsWin;

			private int _Id;

			private long _Time;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto SummaryInfo
			{
				get => _SummaryInfo;
				set => _SummaryInfo = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "IsWin", DataFormat = DataFormat.Default)]
			public bool IsWin
			{
				get => _IsWin;
				set => _IsWin = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
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

		private List<ReporItemProto> _Stages;

		private List<ReporItemProto> _SuperStages;

		private IExtension extensionObject;

		[ProtoMember(2, Name = "Stages", DataFormat = DataFormat.Default)]
		public List<ReporItemProto> Stages

		{

			get => _Stages;

			set => _Stages = value;

		}

		[ProtoMember(3, Name = "SuperStages", DataFormat = DataFormat.Default)]
		public List<ReporItemProto> SuperStages

		{

			get => _SuperStages;

			set => _SuperStages = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

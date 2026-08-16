using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RankingBattleReportProto")]
	public class RankingBattleReportProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ReportItemProto")]
		public class ReportItemProto : IExtensible
		{
			private int _Id;

			private PlayerSummaryInfoProto _Targeter;

			private long _Time;

			private int _RankIngChange;

			private bool _IsAttacker;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Targeter", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto Targeter
			{
				get => _Targeter;
				set => _Targeter = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "RankIngChange", DataFormat = DataFormat.TwosComplement)]
			public int RankIngChange
			{
				get => _RankIngChange;
				set => _RankIngChange = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "IsAttacker", DataFormat = DataFormat.Default)]
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

		private List<ReportItemProto> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ReportItemProto> Items

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

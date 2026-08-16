using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPersonTargetInfoProto")]
	public class CrossPersonTargetInfoProto : IExtensible
	{
		private string _Id;

		private CrossPlayerSummaryInfoProto _SummaryInfo;

		private BattleFormationProto _ForamtionInfo;

		private CrossPersonSeasonInfoProto _SeasonInfo;

		private CrossPersonSeasonInfoProto _HistoryInfo;

		private int _WinGetScore;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.Default)]
		public string Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public CrossPlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ForamtionInfo", DataFormat = DataFormat.Default)]
		public BattleFormationProto ForamtionInfo
		{
			get => _ForamtionInfo;
			set => _ForamtionInfo = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "SeasonInfo", DataFormat = DataFormat.Default)]
		public CrossPersonSeasonInfoProto SeasonInfo
		{
			get => _SeasonInfo;
			set => _SeasonInfo = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "HistoryInfo", DataFormat = DataFormat.Default)]
		public CrossPersonSeasonInfoProto HistoryInfo
		{
			get => _HistoryInfo;
			set => _HistoryInfo = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "WinGetScore", DataFormat = DataFormat.TwosComplement)]
		public int WinGetScore
		{
			get => _WinGetScore;
			set => _WinGetScore = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

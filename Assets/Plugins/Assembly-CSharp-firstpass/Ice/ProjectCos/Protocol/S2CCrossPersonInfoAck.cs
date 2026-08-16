using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonInfoAck")]
	public class S2CCrossPersonInfoAck : IExtensible
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
			LevelLess = 3
		}

		private ResultCode _Code;

		private PlayerCrossPersonInfoProto _Info;

		private CrossPersonSeasonInfoProto _HistorySeasonInfo;

		private CrossPersonSeasonInfoProto _LastSeasonInfo;

		private CrossPlayerSummaryInfoProto _WinnerInfo;

		private string _Id;

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

		[ProtoMember(2, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public PlayerCrossPersonInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "HistorySeasonInfo", DataFormat = DataFormat.Default)]
		public CrossPersonSeasonInfoProto HistorySeasonInfo
		{
			get => _HistorySeasonInfo;
			set => _HistorySeasonInfo = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "LastSeasonInfo", DataFormat = DataFormat.Default)]
		public CrossPersonSeasonInfoProto LastSeasonInfo
		{
			get => _LastSeasonInfo;
			set => _LastSeasonInfo = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "WinnerInfo", DataFormat = DataFormat.Default)]
		public CrossPlayerSummaryInfoProto WinnerInfo
		{
			get => _WinnerInfo;
			set => _WinnerInfo = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Id", DataFormat = DataFormat.Default)]
		public string Id
		{
			get => _Id;
			set => _Id = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildInfoProto")]
	public class CrossGuildInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "PrevSeasonItemProto")]
		public class PrevSeasonItemProto : IExtensible
		{
			private int _Raking;

			private string _Name;

			private int _Icon;

			private int _ReamNum;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Raking", DataFormat = DataFormat.TwosComplement)]
			public int Raking
			{
				get => _Raking;
				set => _Raking = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
			public int Icon
			{
				get => _Icon;
				set => _Icon = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "ReamNum", DataFormat = DataFormat.TwosComplement)]
			public int ReamNum
			{
				get => _ReamNum;
				set => _ReamNum = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "StatusEnum")]
		public enum StatusEnum
		{
			[ProtoEnum(Name = "PrevJoin", Value = 0)]
			PrevJoin = 0,
			[ProtoEnum(Name = "PrevGetTarget", Value = 1)]
			PrevGetTarget = 1,
			[ProtoEnum(Name = "PrevRound1Start", Value = 2)]
			PrevRound1Start = 2,
			[ProtoEnum(Name = "PrevRound2Start", Value = 3)]
			PrevRound2Start = 3,
			[ProtoEnum(Name = "SeasonFinish", Value = 4)]
			SeasonFinish = 4
		}

		private List<PrevSeasonItemProto> _PrevSeasonInfo;

		private StatusEnum _Status;

		private long _OverTime;

		private int _TotalJoinCount;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "PrevSeasonInfo", DataFormat = DataFormat.Default)]
		public List<PrevSeasonItemProto> PrevSeasonInfo

		{

			get => _PrevSeasonInfo;

			set => _PrevSeasonInfo = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public StatusEnum Status
		{
			get
			{
				return default(StatusEnum);
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
		public long OverTime
		{
			get => _OverTime;
			set => _OverTime = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "TotalJoinCount", DataFormat = DataFormat.TwosComplement)]
		public int TotalJoinCount
		{
			get => _TotalJoinCount;
			set => _TotalJoinCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

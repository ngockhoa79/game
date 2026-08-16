using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildReplayProto")]
	public class CrossGuildReplayProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "LineInfoProto")]
		public class LineInfoProto : IExtensible
		{
			private CrossGuildBattleReportSummaryProto.LineResultProto _LineProto;

			private int _RowIndexOfSelf;

			private int _ColunmIndexOfSelf;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "LineProto", DataFormat = DataFormat.Default)]
			public CrossGuildBattleReportSummaryProto.LineResultProto LineProto
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			[ProtoMember(2, IsRequired = true, Name = "RowIndexOfSelf", DataFormat = DataFormat.TwosComplement)]
			public int RowIndexOfSelf
			{
				get => _RowIndexOfSelf;
				set => _RowIndexOfSelf = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "ColunmIndexOfSelf", DataFormat = DataFormat.TwosComplement)]
			public int ColunmIndexOfSelf
			{
				get => _ColunmIndexOfSelf;
				set => _ColunmIndexOfSelf = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private LineInfoProto _FirstRound;

		private LineInfoProto _SecondRound;

		private int _CurBattleCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FirstRound", DataFormat = DataFormat.Default)]
		public LineInfoProto FirstRound
		{
			get => _FirstRound;
			set => _FirstRound = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SecondRound", DataFormat = DataFormat.Default)]
		public LineInfoProto SecondRound
		{
			get => _SecondRound;
			set => _SecondRound = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "CurBattleCount", DataFormat = DataFormat.TwosComplement)]
		public int CurBattleCount
		{
			get => _CurBattleCount;
			set => _CurBattleCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

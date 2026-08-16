using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildBattleReportSummaryProto")]
	public class CrossGuildBattleReportSummaryProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "NameInfoProto")]
		public class NameInfoProto : IExtensible
		{
			private string _Name;

			private int _PosIndex;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "PosIndex", DataFormat = DataFormat.TwosComplement)]
			public int PosIndex
			{
				get => _PosIndex;
				set => _PosIndex = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "CellInfo")]
		public class CellInfo : IExtensible
		{
			private int _KillerIndex;

			private int _DeaderIndex;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "KillerIndex", DataFormat = DataFormat.TwosComplement)]
			public int KillerIndex
			{
				get => _KillerIndex;
				set => _KillerIndex = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "DeaderIndex", DataFormat = DataFormat.TwosComplement)]
			public int DeaderIndex
			{
				get => _DeaderIndex;
				set => _DeaderIndex = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "LineResultProto")]
		public class LineResultProto : IExtensible
		{
			private int _LineIndex;

			private List<CellInfo> _DeadList;

			private bool _IsWin;

			private bool _IsPieceExists;

			private List<NameInfoProto> _Names;

			private int _PrevLeftMark;

			private int _PrevRightMark;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "LineIndex", DataFormat = DataFormat.TwosComplement)]
			public int LineIndex
			{
				get => _LineIndex;
				set => _LineIndex = value;
			}

			[ProtoMember(2, Name = "DeadList", DataFormat = DataFormat.Default)]
			public List<CellInfo> DeadList

			{

				get => _DeadList;

				set => _DeadList = value;

			}

			[ProtoMember(3, IsRequired = true, Name = "IsWin", DataFormat = DataFormat.Default)]
			public bool IsWin
			{
				get => _IsWin;
				set => _IsWin = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "IsPieceExists", DataFormat = DataFormat.Default)]
			public bool IsPieceExists
			{
				get => _IsPieceExists;
				set => _IsPieceExists = value;
			}

			[ProtoMember(5, Name = "Names", DataFormat = DataFormat.Default)]
			public List<NameInfoProto> Names

			{

				get => _Names;

				set => _Names = value;

			}

			[ProtoMember(6, IsRequired = true, Name = "PrevLeftMark", DataFormat = DataFormat.TwosComplement)]
			public int PrevLeftMark
			{
				get => _PrevLeftMark;
				set => _PrevLeftMark = value;
			}

			[ProtoMember(7, IsRequired = true, Name = "PrevRightMark", DataFormat = DataFormat.TwosComplement)]
			public int PrevRightMark
			{
				get => _PrevRightMark;
				set => _PrevRightMark = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<LineResultProto> _Lines;

		private long _Time;

		private bool _IsFirstRound;

		private int _RowIndexOfSelf;

		private int _ColunmIndexOfSelf;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Lines", DataFormat = DataFormat.Default)]
		public List<LineResultProto> Lines

		{

			get => _Lines;

			set => _Lines = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public long Time
		{
			get => _Time;
			set => _Time = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsFirstRound", DataFormat = DataFormat.Default)]
		public bool IsFirstRound
		{
			get => _IsFirstRound;
			set => _IsFirstRound = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "RowIndexOfSelf", DataFormat = DataFormat.TwosComplement)]
		public int RowIndexOfSelf
		{
			get => _RowIndexOfSelf;
			set => _RowIndexOfSelf = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "ColunmIndexOfSelf", DataFormat = DataFormat.TwosComplement)]
		public int ColunmIndexOfSelf
		{
			get => _ColunmIndexOfSelf;
			set => _ColunmIndexOfSelf = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

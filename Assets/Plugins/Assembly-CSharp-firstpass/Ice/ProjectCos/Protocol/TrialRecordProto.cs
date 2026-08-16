using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TrialRecordProto")]
	public class TrialRecordProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "AsStageProto")]
		public class AsStageProto : IExtensible
		{
			private int _Ranking;

			private string _Winning;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
			public int Ranking
			{
				get => _Ranking;
				set => _Ranking = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Winning", DataFormat = DataFormat.Default)]
			public string Winning
			{
				get => _Winning;
				set => _Winning = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "SuperStegInfo")]
		public class SuperStegInfo : IExtensible
		{
			private ulong _PlayerId;

			private string _Name;

			private string _Winning;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
			public ulong PlayerId
			{
				get => _PlayerId;
				set => _PlayerId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Winning", DataFormat = DataFormat.Default)]
			public string Winning
			{
				get => _Winning;
				set => _Winning = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private AsStageProto _AsNormalStageInfo;

		private AsStageProto _AsSuperSatgeInfo;

		private int _SuperWin;

		private int _NormalWin;

		private int _TrialCoin;

		private SuperStegInfo _FirstSuperInfo;

		private bool _IsNormalStageNow;

		private bool _IsSuperStageNow;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "AsNormalStageInfo", DataFormat = DataFormat.Default)]
		public AsStageProto AsNormalStageInfo
		{
			get => _AsNormalStageInfo;
			set => _AsNormalStageInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "AsSuperSatgeInfo", DataFormat = DataFormat.Default)]
		public AsStageProto AsSuperSatgeInfo
		{
			get => _AsSuperSatgeInfo;
			set => _AsSuperSatgeInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "SuperWin", DataFormat = DataFormat.TwosComplement)]
		public int SuperWin
		{
			get => _SuperWin;
			set => _SuperWin = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "NormalWin", DataFormat = DataFormat.TwosComplement)]
		public int NormalWin
		{
			get => _NormalWin;
			set => _NormalWin = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "TrialCoin", DataFormat = DataFormat.TwosComplement)]
		public int TrialCoin
		{
			get => _TrialCoin;
			set => _TrialCoin = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "FirstSuperInfo", DataFormat = DataFormat.Default)]
		public SuperStegInfo FirstSuperInfo
		{
			get => _FirstSuperInfo;
			set => _FirstSuperInfo = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "IsNormalStageNow", DataFormat = DataFormat.Default)]
		public bool IsNormalStageNow
		{
			get => _IsNormalStageNow;
			set => _IsNormalStageNow = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "IsSuperStageNow", DataFormat = DataFormat.Default)]
		public bool IsSuperStageNow
		{
			get => _IsSuperStageNow;
			set => _IsSuperStageNow = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

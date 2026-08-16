using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EscortPlayerInfoProto")]
	public class EscortPlayerInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "EscortRecord")]
		public class EscortRecord : IExtensible
		{
			private int _DefenseSuccess;

			private int _DefenseFail;

			private int _WrestSuccess;

			private int _WrestFail;

			private int _Exp;

			private int _Gain;

			private int _Loss;

			private int _EndSuccess;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "DefenseSuccess", DataFormat = DataFormat.TwosComplement)]
			public int DefenseSuccess
			{
				get => _DefenseSuccess;
				set => _DefenseSuccess = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "DefenseFail", DataFormat = DataFormat.TwosComplement)]
			public int DefenseFail
			{
				get => _DefenseFail;
				set => _DefenseFail = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "WrestSuccess", DataFormat = DataFormat.TwosComplement)]
			public int WrestSuccess
			{
				get => _WrestSuccess;
				set => _WrestSuccess = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "WrestFail", DataFormat = DataFormat.TwosComplement)]
			public int WrestFail
			{
				get => _WrestFail;
				set => _WrestFail = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
			public int Exp
			{
				get => _Exp;
				set => _Exp = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "Gain", DataFormat = DataFormat.TwosComplement)]
			public int Gain
			{
				get => _Gain;
				set => _Gain = value;
			}

			[ProtoMember(7, IsRequired = true, Name = "Loss", DataFormat = DataFormat.TwosComplement)]
			public int Loss
			{
				get => _Loss;
				set => _Loss = value;
			}

			[ProtoMember(8, IsRequired = true, Name = "EndSuccess", DataFormat = DataFormat.TwosComplement)]
			public int EndSuccess
			{
				get => _EndSuccess;
				set => _EndSuccess = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _Level;

		private int _TotalExp;

		private int _UsedCount;

		private int _WrestCount;

		private EscortCompleteInfoProto _CompleteReward;

		private EscortCarInfoProto _CarInfoIfRunning;

		private EscortCarInfoProto.InspireInfoProto _InspireInfo;

		private EscortRecord _RecordInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TotalExp", DataFormat = DataFormat.TwosComplement)]
		public int TotalExp
		{
			get => _TotalExp;
			set => _TotalExp = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "UsedCount", DataFormat = DataFormat.TwosComplement)]
		public int UsedCount
		{
			get => _UsedCount;
			set => _UsedCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "WrestCount", DataFormat = DataFormat.TwosComplement)]
		public int WrestCount
		{
			get => _WrestCount;
			set => _WrestCount = value;
		}

		[ProtoMember(5, IsRequired = false, Name = "CompleteReward", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public EscortCompleteInfoProto CompleteReward
		{
			get => _CompleteReward;
			set => _CompleteReward = value;
		}

		[ProtoMember(6, IsRequired = false, Name = "CarInfoIfRunning", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public EscortCarInfoProto CarInfoIfRunning
		{
			get => _CarInfoIfRunning;
			set => _CarInfoIfRunning = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "InspireInfo", DataFormat = DataFormat.Default)]
		public EscortCarInfoProto.InspireInfoProto InspireInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(8, IsRequired = true, Name = "RecordInfo", DataFormat = DataFormat.Default)]
		public EscortRecord RecordInfo
		{
			get => _RecordInfo;
			set => _RecordInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

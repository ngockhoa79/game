using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SContinueChargeInfoAck")]
	public class C2SContinueChargeInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private ContinueChargeInfoProto _ExpenseInfo;

		private int _ChargeMark;

		private int _BuyMark;

		private int _TotalMark;

		private int _TodayCharge;

		private int _TotalRewardState;

		private int _PassDayIndex;

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

		[ProtoMember(2, IsRequired = true, Name = "ExpenseInfo", DataFormat = DataFormat.Default)]
		public ContinueChargeInfoProto ExpenseInfo
		{
			get => _ExpenseInfo;
			set => _ExpenseInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ChargeMark", DataFormat = DataFormat.TwosComplement)]
		public int ChargeMark
		{
			get => _ChargeMark;
			set => _ChargeMark = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "BuyMark", DataFormat = DataFormat.TwosComplement)]
		public int BuyMark
		{
			get => _BuyMark;
			set => _BuyMark = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "TotalMark", DataFormat = DataFormat.TwosComplement)]
		public int TotalMark
		{
			get => _TotalMark;
			set => _TotalMark = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "TodayCharge", DataFormat = DataFormat.TwosComplement)]
		public int TodayCharge
		{
			get => _TodayCharge;
			set => _TodayCharge = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "TotalRewardState", DataFormat = DataFormat.TwosComplement)]
		public int TotalRewardState
		{
			get => _TotalRewardState;
			set => _TotalRewardState = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "PassDayIndex", DataFormat = DataFormat.TwosComplement)]
		public int PassDayIndex
		{
			get => _PassDayIndex;
			set => _PassDayIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

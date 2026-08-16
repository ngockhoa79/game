using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CBigWheelPickAck")]
	public class S2CBigWheelPickAck : IExtensible
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
			[ProtoEnum(Name = "MoneyLess", Value = 3)]
			MoneyLess = 3
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private List<int> _RewardIndexs;

		private int _GrandTotal;

		private int _NextPayCost;

		private int _BigWheelBigReward;

		private int _Score;

		private long _NextFreeTime;

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

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		[ProtoMember(3, Name = "RewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> RewardIndexs

		{

			get => _RewardIndexs;

			set => _RewardIndexs = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "GrandTotal", DataFormat = DataFormat.TwosComplement)]
		public int GrandTotal
		{
			get => _GrandTotal;
			set => _GrandTotal = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "NextPayCost", DataFormat = DataFormat.TwosComplement)]
		public int NextPayCost
		{
			get => _NextPayCost;
			set => _NextPayCost = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "BigWheelBigReward", DataFormat = DataFormat.TwosComplement)]
		public int BigWheelBigReward
		{
			get => _BigWheelBigReward;
			set => _BigWheelBigReward = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get => _Score;
			set => _Score = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "NextFreeTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFreeTime
		{
			get => _NextFreeTime;
			set => _NextFreeTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

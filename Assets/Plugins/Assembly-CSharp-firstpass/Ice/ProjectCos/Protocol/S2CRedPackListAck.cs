using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRedPackListAck")]
	public class S2CRedPackListAck : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "CurSendRedPackProto")]
		public class CurSendRedPackProto : IExtensible
		{
			private int _LastRankingValue;

			private RankingRedPackProto _SendingInfo;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "LastRankingValue", DataFormat = DataFormat.TwosComplement)]
			public int LastRankingValue
			{
				get => _LastRankingValue;
				set => _LastRankingValue = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "SendingInfo", DataFormat = DataFormat.Default)]
			public RankingRedPackProto SendingInfo
			{
				get => _SendingInfo;
				set => _SendingInfo = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private int _RedPackPickCount;

		private List<RedPackCoolDownTimeProto> _PickCoolDownTimes;

		private int _RedPackRemainSendCount;

		private int _BuySendRedPackTimes;

		private List<RankingRedPackProto> _RedPacks;

		private CurSendRedPackProto _CurSendInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "RedPackPickCount", DataFormat = DataFormat.TwosComplement)]
		public int RedPackPickCount
		{
			get => _RedPackPickCount;
			set => _RedPackPickCount = value;
		}

		[ProtoMember(3, Name = "PickCoolDownTimes", DataFormat = DataFormat.Default)]
		public List<RedPackCoolDownTimeProto> PickCoolDownTimes

		{

			get => _PickCoolDownTimes;

			set => _PickCoolDownTimes = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "RedPackRemainSendCount", DataFormat = DataFormat.TwosComplement)]
		public int RedPackRemainSendCount
		{
			get => _RedPackRemainSendCount;
			set => _RedPackRemainSendCount = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "BuySendRedPackTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuySendRedPackTimes
		{
			get => _BuySendRedPackTimes;
			set => _BuySendRedPackTimes = value;
		}

		[ProtoMember(6, Name = "RedPacks", DataFormat = DataFormat.Default)]
		public List<RankingRedPackProto> RedPacks

		{

			get => _RedPacks;

			set => _RedPacks = value;

		}

		[ProtoMember(7, IsRequired = true, Name = "CurSendInfo", DataFormat = DataFormat.Default)]
		public CurSendRedPackProto CurSendInfo
		{
			get => _CurSendInfo;
			set => _CurSendInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ConfigProto")]
	public class ConfigProto : IExtensible
	{
		private long _StartTime;

		private long _EndTime;

		private int _DayCount;

		private int _ChargeCost;

		private List<CountReward> _DayRewards;

		private List<GiftReward> _DayGifts;

		private List<CountReward> _TotalRewards;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "StartTime", DataFormat = DataFormat.TwosComplement)]
		public long StartTime
		{
			get => _StartTime;
			set => _StartTime = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "EndTime", DataFormat = DataFormat.TwosComplement)]
		public long EndTime
		{
			get => _EndTime;
			set => _EndTime = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "DayCount", DataFormat = DataFormat.TwosComplement)]
		public int DayCount
		{
			get => _DayCount;
			set => _DayCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ChargeCost", DataFormat = DataFormat.TwosComplement)]
		public int ChargeCost
		{
			get => _ChargeCost;
			set => _ChargeCost = value;
		}

		[ProtoMember(5, Name = "DayRewards", DataFormat = DataFormat.Default)]
		public List<CountReward> DayRewards

		{

			get => _DayRewards;

			set => _DayRewards = value;

		}

		[ProtoMember(6, Name = "DayGifts", DataFormat = DataFormat.Default)]
		public List<GiftReward> DayGifts

		{

			get => _DayGifts;

			set => _DayGifts = value;

		}

		[ProtoMember(7, Name = "TotalRewards", DataFormat = DataFormat.Default)]
		public List<CountReward> TotalRewards

		{

			get => _TotalRewards;

			set => _TotalRewards = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

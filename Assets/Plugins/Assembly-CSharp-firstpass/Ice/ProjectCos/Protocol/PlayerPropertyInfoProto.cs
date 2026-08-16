using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerPropertyInfoProto")]
	public class PlayerPropertyInfoProto : IExtensible
	{
		private int _Gold;

		private int _Crystal;

		private int _Energy;

		private int _Level;

		private int _ExpTotal;

		private int _VipLevel;

		private long _LastRefreshEnergyTime;

		private int _TransformSoul;

		private int _BuyEnergyTimes;

		private int _BuyGoldTimes;

		private int _TrialCoin;

		private int _TotalCrystalCharge;

		private int _GuildContribution;

		private int _CourageProof;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get => _Gold;
			set => _Gold = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public int Crystal
		{
			get => _Crystal;
			set => _Crystal = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Energy", DataFormat = DataFormat.TwosComplement)]
		public int Energy
		{
			get => _Energy;
			set => _Energy = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "ExpTotal", DataFormat = DataFormat.TwosComplement)]
		public int ExpTotal
		{
			get => _ExpTotal;
			set => _ExpTotal = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "VipLevel", DataFormat = DataFormat.TwosComplement)]
		public int VipLevel
		{
			get => _VipLevel;
			set => _VipLevel = value;
		}

		[ProtoMember(11, IsRequired = true, Name = "LastRefreshEnergyTime", DataFormat = DataFormat.TwosComplement)]
		public long LastRefreshEnergyTime
		{
			get => _LastRefreshEnergyTime;
			set => _LastRefreshEnergyTime = value;
		}

		[ProtoMember(12, IsRequired = true, Name = "TransformSoul", DataFormat = DataFormat.TwosComplement)]
		public int TransformSoul
		{
			get => _TransformSoul;
			set => _TransformSoul = value;
		}

		[ProtoMember(13, IsRequired = true, Name = "BuyEnergyTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyEnergyTimes
		{
			get => _BuyEnergyTimes;
			set => _BuyEnergyTimes = value;
		}

		[ProtoMember(14, IsRequired = true, Name = "BuyGoldTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyGoldTimes
		{
			get => _BuyGoldTimes;
			set => _BuyGoldTimes = value;
		}

		[ProtoMember(15, IsRequired = true, Name = "TrialCoin", DataFormat = DataFormat.TwosComplement)]
		public int TrialCoin
		{
			get => _TrialCoin;
			set => _TrialCoin = value;
		}

		[ProtoMember(16, IsRequired = true, Name = "TotalCrystalCharge", DataFormat = DataFormat.TwosComplement)]
		public int TotalCrystalCharge
		{
			get => _TotalCrystalCharge;
			set => _TotalCrystalCharge = value;
		}

		[ProtoMember(17, IsRequired = true, Name = "GuildContribution", DataFormat = DataFormat.TwosComplement)]
		public int GuildContribution
		{
			get => _GuildContribution;
			set => _GuildContribution = value;
		}

		[ProtoMember(18, IsRequired = true, Name = "CourageProof", DataFormat = DataFormat.TwosComplement)]
		public int CourageProof
		{
			get => _CourageProof;
			set => _CourageProof = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

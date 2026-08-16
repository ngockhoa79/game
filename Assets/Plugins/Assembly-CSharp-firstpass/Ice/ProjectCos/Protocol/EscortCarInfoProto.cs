using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EscortCarInfoProto")]
	public class EscortCarInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "InspireInfoProto")]
		public class InspireInfoProto : IExtensible
		{
			private int _PromoteValue;

			private int _Count;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "PromoteValue", DataFormat = DataFormat.TwosComplement)]
			public int PromoteValue
			{
				get => _PromoteValue;
				set => _PromoteValue = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "SpeedCodeEnum")]
		public enum SpeedCodeEnum
		{
			[ProtoEnum(Name = "None", Value = 0)]
			None = 0,
			[ProtoEnum(Name = "X1", Value = 1)]
			X1 = 1,
			[ProtoEnum(Name = "X2", Value = 2)]
			X2 = 2,
			[ProtoEnum(Name = "X3", Value = 3)]
			X3 = 3,
			[ProtoEnum(Name = "X4", Value = 4)]
			X4 = 4
		}

		private PlayerSummaryInfoProto _FriendSummaryInfo;

		private int _CarId;

		private string _Speed;

		private string _Distance;

		private int _RemainBaseGold;

		private int _RemainAdditionalGold;

		private int _WrestFailPunish;

		private SpeedCodeEnum _SpeedCode;

		private int _EscortLevel;

		private InspireInfoProto _InspireInfo;

		private int _Id;

		private int _OriginalBaseGold;

		private int _OriginalAdditionalGold;

		private bool _IsOnceOwned;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FriendSummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto FriendSummaryInfo
		{
			get => _FriendSummaryInfo;
			set => _FriendSummaryInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CarId", DataFormat = DataFormat.TwosComplement)]
		public int CarId
		{
			get => _CarId;
			set => _CarId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Speed", DataFormat = DataFormat.Default)]
		public string Speed
		{
			get => _Speed;
			set => _Speed = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Distance", DataFormat = DataFormat.Default)]
		public string Distance
		{
			get => _Distance;
			set => _Distance = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "RemainBaseGold", DataFormat = DataFormat.TwosComplement)]
		public int RemainBaseGold
		{
			get => _RemainBaseGold;
			set => _RemainBaseGold = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "RemainAdditionalGold", DataFormat = DataFormat.TwosComplement)]
		public int RemainAdditionalGold
		{
			get => _RemainAdditionalGold;
			set => _RemainAdditionalGold = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "WrestFailPunish", DataFormat = DataFormat.TwosComplement)]
		public int WrestFailPunish
		{
			get => _WrestFailPunish;
			set => _WrestFailPunish = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "SpeedCode", DataFormat = DataFormat.TwosComplement)]
		public SpeedCodeEnum SpeedCode
		{
			get
			{
				return default(SpeedCodeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(9, IsRequired = true, Name = "EscortLevel", DataFormat = DataFormat.TwosComplement)]
		public int EscortLevel
		{
			get => _EscortLevel;
			set => _EscortLevel = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "InspireInfo", DataFormat = DataFormat.Default)]
		public InspireInfoProto InspireInfo
		{
			get => _InspireInfo;
			set => _InspireInfo = value;
		}

		[ProtoMember(11, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(12, IsRequired = true, Name = "OriginalBaseGold", DataFormat = DataFormat.TwosComplement)]
		public int OriginalBaseGold
		{
			get => _OriginalBaseGold;
			set => _OriginalBaseGold = value;
		}

		[ProtoMember(13, IsRequired = true, Name = "OriginalAdditionalGold", DataFormat = DataFormat.TwosComplement)]
		public int OriginalAdditionalGold
		{
			get => _OriginalAdditionalGold;
			set => _OriginalAdditionalGold = value;
		}

		[ProtoMember(14, IsRequired = true, Name = "IsOnceOwned", DataFormat = DataFormat.Default)]
		public bool IsOnceOwned
		{
			get => _IsOnceOwned;
			set => _IsOnceOwned = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

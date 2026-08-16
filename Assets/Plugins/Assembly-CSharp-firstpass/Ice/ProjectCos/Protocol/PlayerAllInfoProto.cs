using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerAllInfoProto")]
	public class PlayerAllInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "NewStagesInfoProto")]
		public class NewStagesInfoProto : IExtensible
		{
			private int _NewStagesMark;

			private int _Data;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "NewStagesMark", DataFormat = DataFormat.TwosComplement)]
			public int NewStagesMark
			{
				get => _NewStagesMark;
				set => _NewStagesMark = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Data", DataFormat = DataFormat.TwosComplement)]
			public int Data
			{
				get => _Data;
				set => _Data = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private ulong _PlayerId;

		private string _Name;

		private PlayerPropertyInfoProto _PropertyBaseInfo;

		private PlayerBagInfoProto _BagInfo;

		private PlayerHerosBagProto _HerosBagInfo;

		private PlayerFormationItemInfoProto _FormationInfo;

		private QuestDuplicateProto _QuestInfo;

		private PlayerLotteryInfoProto _LotteryInfo;

		private PlayerRobberyInfoProto _RobberyInfo;

		private ThingRecordsProto _ThingRecordsInfo;

		private List<NewNoticeProto> _NewNotices;

		private ChatProto _ChatInfo;

		private OnlineRewardProto _OnlineRewardInfo;

		private AccumulationSignProto _AccumulationSignInfo;

		private FriendInfoProto _FriendInfo;

		private NewStagesInfoProto _NewStagesInfo;

		private int _ReputationValue;

		private OperateProto _OperateInfo;

		private int _HeadIconId;

		private string _Signature;

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

		[ProtoMember(3, IsRequired = true, Name = "PropertyBaseInfo", DataFormat = DataFormat.Default)]
		public PlayerPropertyInfoProto PropertyBaseInfo
		{
			get => _PropertyBaseInfo;
			set => _PropertyBaseInfo = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "BagInfo", DataFormat = DataFormat.Default)]
		public PlayerBagInfoProto BagInfo
		{
			get => _BagInfo;
			set => _BagInfo = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "HerosBagInfo", DataFormat = DataFormat.Default)]
		public PlayerHerosBagProto HerosBagInfo
		{
			get => _HerosBagInfo;
			set => _HerosBagInfo = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "FormationInfo", DataFormat = DataFormat.Default)]
		public PlayerFormationItemInfoProto FormationInfo
		{
			get => _FormationInfo;
			set => _FormationInfo = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "QuestInfo", DataFormat = DataFormat.Default)]
		public QuestDuplicateProto QuestInfo
		{
			get => _QuestInfo;
			set => _QuestInfo = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "LotteryInfo", DataFormat = DataFormat.Default)]
		public PlayerLotteryInfoProto LotteryInfo
		{
			get => _LotteryInfo;
			set => _LotteryInfo = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "RobberyInfo", DataFormat = DataFormat.Default)]
		public PlayerRobberyInfoProto RobberyInfo
		{
			get => _RobberyInfo;
			set => _RobberyInfo = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "ThingRecordsInfo", DataFormat = DataFormat.Default)]
		public ThingRecordsProto ThingRecordsInfo
		{
			get => _ThingRecordsInfo;
			set => _ThingRecordsInfo = value;
		}

		[ProtoMember(11, Name = "NewNotices", DataFormat = DataFormat.Default)]
		public List<NewNoticeProto> NewNotices

		{

			get => _NewNotices;

			set => _NewNotices = value;

		}

		[ProtoMember(13, IsRequired = true, Name = "ChatInfo", DataFormat = DataFormat.Default)]
		public ChatProto ChatInfo
		{
			get => _ChatInfo;
			set => _ChatInfo = value;
		}

		[ProtoMember(14, IsRequired = true, Name = "OnlineRewardInfo", DataFormat = DataFormat.Default)]
		public OnlineRewardProto OnlineRewardInfo
		{
			get => _OnlineRewardInfo;
			set => _OnlineRewardInfo = value;
		}

		[ProtoMember(15, IsRequired = true, Name = "AccumulationSignInfo", DataFormat = DataFormat.Default)]
		public AccumulationSignProto AccumulationSignInfo
		{
			get => _AccumulationSignInfo;
			set => _AccumulationSignInfo = value;
		}

		[ProtoMember(16, IsRequired = true, Name = "FriendInfo", DataFormat = DataFormat.Default)]
		public FriendInfoProto FriendInfo
		{
			get => _FriendInfo;
			set => _FriendInfo = value;
		}

		[ProtoMember(17, IsRequired = true, Name = "NewStagesInfo", DataFormat = DataFormat.Default)]
		public NewStagesInfoProto NewStagesInfo
		{
			get => _NewStagesInfo;
			set => _NewStagesInfo = value;
		}

		[ProtoMember(19, IsRequired = true, Name = "ReputationValue", DataFormat = DataFormat.TwosComplement)]
		public int ReputationValue
		{
			get => _ReputationValue;
			set => _ReputationValue = value;
		}

		[ProtoMember(20, IsRequired = true, Name = "OperateInfo", DataFormat = DataFormat.Default)]
		public OperateProto OperateInfo
		{
			get => _OperateInfo;
			set => _OperateInfo = value;
		}

		[ProtoMember(21, IsRequired = true, Name = "HeadIconId", DataFormat = DataFormat.TwosComplement)]
		public int HeadIconId
		{
			get => _HeadIconId;
			set => _HeadIconId = value;
		}

		[ProtoMember(22, IsRequired = true, Name = "Signature", DataFormat = DataFormat.Default)]
		public string Signature
		{
			get => _Signature;
			set => _Signature = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FriendInfoProto")]
	public class FriendInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "EggAddRecordProto")]
		public class EggAddRecordProto : IExtensible
		{
			private PlayerSummaryInfoProto _FriendSummary;

			private long _Time;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "FriendSummary", DataFormat = DataFormat.Default)]
			public PlayerSummaryInfoProto FriendSummary
			{
				get => _FriendSummary;
				set => _FriendSummary = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
			public long Time
			{
				get => _Time;
				set => _Time = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<PlayerFriendInfoProto> _Friends;

		private FriendEggsProto _EggsInfo;

		private int _PresentationUsedCount;

		private int _BattleFriendshipCount;

		private int _FriendshipValue;

		private List<EggAddRecordProto> _EggAddRecords;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Friends", DataFormat = DataFormat.Default)]
		public List<PlayerFriendInfoProto> Friends

		{

			get => _Friends;

			set => _Friends = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "EggsInfo", DataFormat = DataFormat.Default)]
		public FriendEggsProto EggsInfo
		{
			get => _EggsInfo;
			set => _EggsInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "PresentationUsedCount", DataFormat = DataFormat.TwosComplement)]
		public int PresentationUsedCount
		{
			get => _PresentationUsedCount;
			set => _PresentationUsedCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "BattleFriendshipCount", DataFormat = DataFormat.TwosComplement)]
		public int BattleFriendshipCount
		{
			get => _BattleFriendshipCount;
			set => _BattleFriendshipCount = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "FriendshipValue", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipValue
		{
			get => _FriendshipValue;
			set => _FriendshipValue = value;
		}

		[ProtoMember(6, Name = "EggAddRecords", DataFormat = DataFormat.Default)]
		public List<EggAddRecordProto> EggAddRecords

		{

			get => _EggAddRecords;

			set => _EggAddRecords = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}

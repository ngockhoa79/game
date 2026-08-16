using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerSummaryInfoProto")]
	public class PlayerSummaryInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "GuildInfoProto")]
		public class GuildInfoProto : IExtensible
		{
			private int _Id;

			private string _Name;

			private int _Icon;

			private int _Level;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
			public int Id
			{
				get => _Id;
				set => _Id = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
			public int Icon
			{
				get => _Icon;
				set => _Icon = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
			public int Level
			{
				get => _Level;
				set => _Level = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private ulong _PlayerId;

		private string _Name;

		private int _HeadIconId;

		private int _Level;

		private int _LeaderId;

		private int _CombatValue;

		private int _LeaderCombatValue;

		private int _LeaderLevel;

		private int _Vip;

		private long _LastLoginTime;

		private GuildInfoProto _GuildInfo;

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

		[ProtoMember(3, IsRequired = true, Name = "HeadIconId", DataFormat = DataFormat.TwosComplement)]
		public int HeadIconId
		{
			get => _HeadIconId;
			set => _HeadIconId = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "LeaderId", DataFormat = DataFormat.TwosComplement)]
		public int LeaderId
		{
			get => _LeaderId;
			set => _LeaderId = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "CombatValue", DataFormat = DataFormat.TwosComplement)]
		public int CombatValue
		{
			get => _CombatValue;
			set => _CombatValue = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "LeaderCombatValue", DataFormat = DataFormat.TwosComplement)]
		public int LeaderCombatValue
		{
			get => _LeaderCombatValue;
			set => _LeaderCombatValue = value;
		}

		[ProtoMember(11, IsRequired = true, Name = "LeaderLevel", DataFormat = DataFormat.TwosComplement)]
		public int LeaderLevel
		{
			get => _LeaderLevel;
			set => _LeaderLevel = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "Vip", DataFormat = DataFormat.TwosComplement)]
		public int Vip
		{
			get => _Vip;
			set => _Vip = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "LastLoginTime", DataFormat = DataFormat.TwosComplement)]
		public long LastLoginTime
		{
			get => _LastLoginTime;
			set => _LastLoginTime = value;
		}

		[ProtoMember(12, IsRequired = true, Name = "GuildInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto GuildInfo
		{
			get => _GuildInfo;
			set => _GuildInfo = value;
		}

		[ProtoMember(13, IsRequired = true, Name = "Signature", DataFormat = DataFormat.Default)]
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

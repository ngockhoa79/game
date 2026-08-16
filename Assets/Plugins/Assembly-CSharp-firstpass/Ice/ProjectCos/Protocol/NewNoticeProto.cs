using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "NewNoticeProto")]
	public class NewNoticeProto : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "ShopPveAppear", Value = 0)]
			ShopPveAppear = 0,
			[ProtoEnum(Name = "Friend", Value = 1)]
			Friend = 1,
			[ProtoEnum(Name = "Mail", Value = 2)]
			Mail = 2,
			[ProtoEnum(Name = "DailyTask", Value = 3)]
			DailyTask = 3,
			[ProtoEnum(Name = "Achievement", Value = 4)]
			Achievement = 4,
			[ProtoEnum(Name = "EscortComplete", Value = 5)]
			EscortComplete = 5,
			[ProtoEnum(Name = "EscortBattleReport", Value = 6)]
			EscortBattleReport = 6,
			[ProtoEnum(Name = "PvpNewBattleReport", Value = 7)]
			PvpNewBattleReport = 7,
			[ProtoEnum(Name = "RobberyReport", Value = 8)]
			RobberyReport = 8,
			[ProtoEnum(Name = "RobberyNotice", Value = 9)]
			RobberyNotice = 9,
			[ProtoEnum(Name = "FriendBattle", Value = 10)]
			FriendBattle = 10,
			[ProtoEnum(Name = "OpenServerActivity", Value = 11)]
			OpenServerActivity = 11,
			[ProtoEnum(Name = "GuildApplication", Value = 12)]
			GuildApplication = 12,
			[ProtoEnum(Name = "GuildParty", Value = 13)]
			GuildParty = 13,
			[ProtoEnum(Name = "GuildTask", Value = 14)]
			GuildTask = 14,
			[ProtoEnum(Name = "GuildJoined", Value = 15)]
			GuildJoined = 15,
			[ProtoEnum(Name = "Cornucopia", Value = 16)]
			Cornucopia = 16,
			[ProtoEnum(Name = "CrossGuild", Value = 17)]
			CrossGuild = 17,
			[ProtoEnum(Name = "GoddessGrail", Value = 18)]
			GoddessGrail = 18,
			[ProtoEnum(Name = "ContinueCharge", Value = 19)]
			ContinueCharge = 19,
			[ProtoEnum(Name = "WeekVipGift", Value = 20)]
			WeekVipGift = 20
		}

		private TypeEnum _Type;

		private byte[] _Data;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Data", DataFormat = DataFormat.Default)]
		public byte[] Data
		{
			get => _Data;
			set => _Data = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

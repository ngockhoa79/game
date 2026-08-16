using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRankingPickRedPackAck")]
	public class S2CRankingPickRedPackAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoFoundRedPackError", Value = 2)]
			NoFoundRedPackError = 2,
			[ProtoEnum(Name = "NoInSending", Value = 3)]
			NoInSending = 3,
			[ProtoEnum(Name = "RedPackIsEmptyError", Value = 4)]
			RedPackIsEmptyError = 4,
			[ProtoEnum(Name = "GuildNotMatch", Value = 5)]
			GuildNotMatch = 5,
			[ProtoEnum(Name = "NoEnoughTimesError", Value = 6)]
			NoEnoughTimesError = 6,
			[ProtoEnum(Name = "InCDError", Value = 7)]
			InCDError = 7
		}

		private ResultCode _Code;

		private int _Reputation;

		private int _Crystal;

		private List<ItemChangeProto> _Items;

		private long _OverTime;

		private int _GuildContribution;

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

		[ProtoMember(2, IsRequired = true, Name = "Reputation", DataFormat = DataFormat.TwosComplement)]
		public int Reputation
		{
			get => _Reputation;
			set => _Reputation = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public int Crystal
		{
			get => _Crystal;
			set => _Crystal = value;
		}

		[ProtoMember(4, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		[ProtoMember(5, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
		public long OverTime
		{
			get => _OverTime;
			set => _OverTime = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "GuildContribution", DataFormat = DataFormat.TwosComplement)]
		public int GuildContribution
		{
			get => _GuildContribution;
			set => _GuildContribution = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildDonateAck")]
	public class S2CGuildDonateAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "IdError", Value = 2)]
			IdError = 2,
			[ProtoEnum(Name = "MoneyLess", Value = 3)]
			MoneyLess = 3,
			[ProtoEnum(Name = "NoGuild", Value = 4)]
			NoGuild = 4,
			[ProtoEnum(Name = "DonateAlready", Value = 5)]
			DonateAlready = 5,
			[ProtoEnum(Name = "DonateCountMax", Value = 6)]
			DonateCountMax = 6
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private int _GuildExpTotal;

		private int _AddContribution;

		private int _CurContribution;

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

		[ProtoMember(3, IsRequired = true, Name = "GuildExpTotal", DataFormat = DataFormat.TwosComplement)]
		public int GuildExpTotal
		{
			get => _GuildExpTotal;
			set => _GuildExpTotal = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "AddContribution", DataFormat = DataFormat.TwosComplement)]
		public int AddContribution
		{
			get => _AddContribution;
			set => _AddContribution = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "CurContribution", DataFormat = DataFormat.TwosComplement)]
		public int CurContribution
		{
			get => _CurContribution;
			set => _CurContribution = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

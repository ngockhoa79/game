using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildPartyStartAck")]
	public class S2CGuildPartyStartAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoGuild", Value = 2)]
			NoGuild = 2,
			[ProtoEnum(Name = "NoPower", Value = 3)]
			NoPower = 3,
			[ProtoEnum(Name = "MoneyLess", Value = 4)]
			MoneyLess = 4,
			[ProtoEnum(Name = "IdError", Value = 5)]
			IdError = 5,
			[ProtoEnum(Name = "StartAlready", Value = 6)]
			StartAlready = 6
		}

		private ResultCode _Code;

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

		[ProtoMember(2, IsRequired = true, Name = "AddContribution", DataFormat = DataFormat.TwosComplement)]
		public int AddContribution
		{
			get => _AddContribution;
			set => _AddContribution = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "CurContribution", DataFormat = DataFormat.TwosComplement)]
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

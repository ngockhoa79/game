using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossGuildJoinAck")]
	public class S2CCrossGuildJoinAck : IExtensible
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
			[ProtoEnum(Name = "GuldLevelLess", Value = 3)]
			GuldLevelLess = 3,
			[ProtoEnum(Name = "JoinAlreay", Value = 4)]
			JoinAlreay = 4,
			[ProtoEnum(Name = "MoneyLess", Value = 5)]
			MoneyLess = 5,
			[ProtoEnum(Name = "NoPower", Value = 6)]
			NoPower = 6
		}

		private ResultCode _Code;

		private long _OverTimeOfGetTarget;

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

		[ProtoMember(2, IsRequired = true, Name = "OverTimeOfGetTarget", DataFormat = DataFormat.TwosComplement)]
		public long OverTimeOfGetTarget
		{
			get => _OverTimeOfGetTarget;
			set => _OverTimeOfGetTarget = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

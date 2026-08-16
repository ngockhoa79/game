using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossGuildFoamtionSetAck")]
	public class S2CCrossGuildFoamtionSetAck : IExtensible
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
			[ProtoEnum(Name = "PostionIsFull", Value = 4)]
			PostionIsFull = 4,
			[ProtoEnum(Name = "PostionIsNotSelf", Value = 5)]
			PostionIsNotSelf = 5,
			[ProtoEnum(Name = "IsDeadAlready", Value = 6)]
			IsDeadAlready = 6
		}

		private ResultCode _Code;

		private CrossGuildFormationProto _Formation;

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

		[ProtoMember(2, IsRequired = true, Name = "Formation", DataFormat = DataFormat.Default)]
		public CrossGuildFormationProto Formation
		{
			get => _Formation;
			set => _Formation = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

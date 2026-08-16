using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildJoinAck")]
	public class S2CGuildJoinAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "HasGuildAlready", Value = 2)]
			HasGuildAlready = 2,
			[ProtoEnum(Name = "Full", Value = 3)]
			Full = 3,
			[ProtoEnum(Name = "IdIsWrong", Value = 4)]
			IdIsWrong = 4,
			[ProtoEnum(Name = "JoinAlready", Value = 5)]
			JoinAlready = 5,
			[ProtoEnum(Name = "JoinFull", Value = 6)]
			JoinFull = 6,
			[ProtoEnum(Name = "InCd", Value = 7)]
			InCd = 7,
			[ProtoEnum(Name = "LevelLess", Value = 8)]
			LevelLess = 8
		}

		private ResultCode _Code;

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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

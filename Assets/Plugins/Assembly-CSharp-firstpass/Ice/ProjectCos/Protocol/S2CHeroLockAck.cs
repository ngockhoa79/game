using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CHeroLockAck")]
	public class S2CHeroLockAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Sucess", Value = 1)]
			Sucess = 1,
			[ProtoEnum(Name = "IsLockedAlready", Value = 2)]
			IsLockedAlready = 2,
			[ProtoEnum(Name = "IsUnlockAlready", Value = 3)]
			IsUnlockAlready = 3,
			[ProtoEnum(Name = "HeroIsNotExists", Value = 4)]
			HeroIsNotExists = 4
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

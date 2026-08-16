using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CFormationSetAck")]
	public class S2CFormationSetAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Result;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Result
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

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGrowingOpenAck")]
	public class S2CGrowingOpenAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "VipLess", Value = 2)]
			VipLess = 2,
			[ProtoEnum(Name = "MoneyLess", Value = 3)]
			MoneyLess = 3,
			[ProtoEnum(Name = "AlreadyOpen", Value = 4)]
			AlreadyOpen = 4
		}

		private ResultCode _Code;

		private int _IndexMark;

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

		[ProtoMember(2, IsRequired = true, Name = "IndexMark", DataFormat = DataFormat.TwosComplement)]
		public int IndexMark
		{
			get => _IndexMark;
			set => _IndexMark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

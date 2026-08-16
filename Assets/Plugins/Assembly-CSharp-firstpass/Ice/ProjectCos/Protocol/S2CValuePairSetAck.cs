using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CValuePairSetAck")]
	public class S2CValuePairSetAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "KeyOrValueIsTooLong", Value = 2)]
			KeyOrValueIsTooLong = 2,
			[ProtoEnum(Name = "CountIsMax", Value = 3)]
			CountIsMax = 3
		}

		private ResultCode _Code;

		private string _Key;

		private string _PrevVaule;

		private string _Value;

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

		[ProtoMember(2, IsRequired = true, Name = "Key", DataFormat = DataFormat.Default)]
		public string Key
		{
			get => _Key;
			set => _Key = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "PrevVaule", DataFormat = DataFormat.Default)]
		public string PrevVaule
		{
			get => _PrevVaule;
			set => _PrevVaule = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
		public string Value
		{
			get => _Value;
			set => _Value = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CSettingMarkAck")]
	public class S2CSettingMarkAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "StatusIsError", Value = 2)]
			StatusIsError = 2
		}

		private ResultCode _Code;

		private SettingProto.SettingEnum _Id;

		private bool _IsOn;

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

		[ProtoMember(2, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public SettingProto.SettingEnum Id
		{
			get
			{
				return default(SettingProto.SettingEnum);
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "IsOn", DataFormat = DataFormat.Default)]
		public bool IsOn
		{
			get => _IsOn;
			set => _IsOn = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

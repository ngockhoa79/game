using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CTrialRefreshStrangerAck")]
	public class S2CTrialRefreshStrangerAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "TimesIsMax", Value = 2)]
			TimesIsMax = 2,
			[ProtoEnum(Name = "MoneyIsLess", Value = 3)]
			MoneyIsLess = 3
		}

		private ResultCode _Code;

		private List<TrialForamtionProto> _Strangers;

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

		[ProtoMember(2, Name = "Strangers", DataFormat = DataFormat.Default)]
		public List<TrialForamtionProto> Strangers

		{

			get => _Strangers;

			set => _Strangers = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

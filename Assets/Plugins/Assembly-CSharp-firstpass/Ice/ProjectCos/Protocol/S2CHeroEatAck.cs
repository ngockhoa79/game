using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CHeroEatAck")]
	public class S2CHeroEatAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "NormalSucess", Value = 1)]
			NormalSucess = 1,
			[ProtoEnum(Name = "SuperSucess_1", Value = 2)]
			SuperSucess1 = 2,
			[ProtoEnum(Name = "SuperSucess_2", Value = 3)]
			SuperSucess2 = 3,
			[ProtoEnum(Name = "SuperSucess_3", Value = 4)]
			SuperSucess3 = 4
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

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

		[ProtoMember(3, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CItemTransformAck")]
	public class S2CItemTransformAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "IndexsHasError", Value = 2)]
			IndexsHasError = 2,
			[ProtoEnum(Name = "BagIsFullError", Value = 3)]
			BagIsFullError = 3
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private int _Gold;

		private int _Soul;

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

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get => _Gold;
			set => _Gold = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Soul", DataFormat = DataFormat.TwosComplement)]
		public int Soul
		{
			get => _Soul;
			set => _Soul = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

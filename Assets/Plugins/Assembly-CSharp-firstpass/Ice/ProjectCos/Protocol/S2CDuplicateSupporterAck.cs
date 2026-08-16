using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CDuplicateSupporterAck")]
	public class S2CDuplicateSupporterAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private List<DuplicateSupporterProto> _Strangers;

		private List<DuplicateSupporterProto> _Friends;

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
		public List<DuplicateSupporterProto> Strangers

		{

			get => _Strangers;

			set => _Strangers = value;

		}

		[ProtoMember(3, Name = "Friends", DataFormat = DataFormat.Default)]
		public List<DuplicateSupporterProto> Friends

		{

			get => _Friends;

			set => _Friends = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

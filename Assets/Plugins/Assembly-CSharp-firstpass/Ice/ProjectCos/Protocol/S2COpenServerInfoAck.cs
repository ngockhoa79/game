using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2COpenServerInfoAck")]
	public class S2COpenServerInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "ActivityClose", Value = 2)]
			ActivityClose = 2
		}

		private ResultCode _Code;

		private DiamondShopInfoProto _ShopInfo;

		private List<TaskItemProto> _TaskInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "ShopInfo", DataFormat = DataFormat.Default)]
		public DiamondShopInfoProto ShopInfo
		{
			get => _ShopInfo;
			set => _ShopInfo = value;
		}

		[ProtoMember(3, Name = "TaskInfo", DataFormat = DataFormat.Default)]
		public List<TaskItemProto> TaskInfo

		{

			get => _TaskInfo;

			set => _TaskInfo = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

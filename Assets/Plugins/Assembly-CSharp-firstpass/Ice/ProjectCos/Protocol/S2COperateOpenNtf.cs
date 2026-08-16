using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2COperateOpenNtf")]
	public class S2COperateOpenNtf : IExtensible
	{
		private OperateProto.OpenInfoProto _Info;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public OperateProto.OpenInfoProto Info
		{
			get
			{
				return null;
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

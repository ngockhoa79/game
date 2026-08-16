using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CItemTransformPreviewAck")]
	public class S2CItemTransformPreviewAck : IExtensible
	{
		private S2CItemTransformAck.ResultCode _Code;

		private TransformPreviewProto _Info;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public S2CItemTransformAck.ResultCode Code
		{
			get
			{
				return default(S2CItemTransformAck.ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public TransformPreviewProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

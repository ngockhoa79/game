using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SItemTransformPreviewReq")]
	public class C2SItemTransformPreviewReq : IExtensible
	{
		private C2SItemTransformReq.TypeEnum _Type;

		private List<int> _Indexs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public C2SItemTransformReq.TypeEnum Type
		{
			get
			{
				return default(C2SItemTransformReq.TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(2, Name = "Indexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> Indexs

		{

			get => _Indexs;

			set => _Indexs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

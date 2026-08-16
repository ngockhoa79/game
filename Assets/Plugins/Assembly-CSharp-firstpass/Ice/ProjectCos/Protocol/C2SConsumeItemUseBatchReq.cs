using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SConsumeItemUseBatchReq")]
	public class C2SConsumeItemUseBatchReq : IExtensible
	{
		private List<int> _Indexs;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Indexs", DataFormat = DataFormat.TwosComplement)]
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

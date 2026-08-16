using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SContinueChargePickTotalReq")]
	public class C2SContinueChargePickTotalReq : IExtensible
	{
		private int _index;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "index", DataFormat = DataFormat.TwosComplement)]
		public int index
		{
			get => _index;
			set => _index = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

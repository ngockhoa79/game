using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SBigWheelPickReq")]
	public class C2SBigWheelPickReq : IExtensible
	{
		private bool _IsTen;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsTen", DataFormat = DataFormat.Default)]
		public bool IsTen
		{
			get => _IsTen;
			set => _IsTen = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

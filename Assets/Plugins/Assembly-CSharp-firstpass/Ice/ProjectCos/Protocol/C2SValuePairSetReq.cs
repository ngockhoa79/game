using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SValuePairSetReq")]
	public class C2SValuePairSetReq : IExtensible
	{
		private string _Key;

		private string _Value;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Key", DataFormat = DataFormat.Default)]
		public string Key
		{
			get => _Key;
			set => _Key = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
		public string Value
		{
			get => _Value;
			set => _Value = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

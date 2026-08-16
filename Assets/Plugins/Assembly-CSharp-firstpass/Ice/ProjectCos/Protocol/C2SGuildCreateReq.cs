using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildCreateReq")]
	public class C2SGuildCreateReq : IExtensible
	{
		private string _Name;

		private int _Icon;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get => _Name;
			set => _Name = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
		public int Icon
		{
			get => _Icon;
			set => _Icon = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

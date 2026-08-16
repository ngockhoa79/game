using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRedPackListReq")]
	public class C2SRedPackListReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Normal", Value = 0)]
			Normal = 0,
			[ProtoEnum(Name = "Guild", Value = 1)]
			Guild = 1
		}

		private TypeEnum _Type;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
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

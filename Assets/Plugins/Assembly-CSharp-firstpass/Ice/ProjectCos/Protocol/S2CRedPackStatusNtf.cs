using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRedPackStatusNtf")]
	public class S2CRedPackStatusNtf : IExtensible
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

		private bool _HasIcon;

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

		[ProtoMember(2, IsRequired = true, Name = "HasIcon", DataFormat = DataFormat.Default)]
		public bool HasIcon
		{
			get => _HasIcon;
			set => _HasIcon = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

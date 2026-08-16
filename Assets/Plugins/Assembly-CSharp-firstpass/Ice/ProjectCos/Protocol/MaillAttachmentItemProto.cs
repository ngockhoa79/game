using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "MaillAttachmentItemProto")]
	public class MaillAttachmentItemProto : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Thing", Value = 1)]
			Thing = 1,
			[ProtoEnum(Name = "BattleReport", Value = 2)]
			BattleReport = 2,
			[ProtoEnum(Name = "Charge", Value = 3)]
			Charge = 3
		}

		private TypeEnum _Type;

		private byte[] _Data;

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

		[ProtoMember(2, IsRequired = true, Name = "Data", DataFormat = DataFormat.Default)]
		public byte[] Data
		{
			get => _Data;
			set => _Data = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

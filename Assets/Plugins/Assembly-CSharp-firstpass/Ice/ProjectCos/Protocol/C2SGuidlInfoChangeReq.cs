using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuidlInfoChangeReq")]
	public class C2SGuidlInfoChangeReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Name", Value = 0)]
			Name = 0,
			[ProtoEnum(Name = "Icon", Value = 1)]
			Icon = 1,
			[ProtoEnum(Name = "Announcement", Value = 2)]
			Announcement = 2
		}

		private TypeEnum _Type;

		private int _IconId;

		private string _Content;

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

		[ProtoMember(2, IsRequired = true, Name = "IconId", DataFormat = DataFormat.TwosComplement)]
		public int IconId
		{
			get => _IconId;
			set => _IconId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get => _Content;
			set => _Content = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

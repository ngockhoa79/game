using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SItemTransformReq")]
	public class C2SItemTransformReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Hero", Value = 1)]
			Hero = 1,
			[ProtoEnum(Name = "Equip", Value = 2)]
			Equip = 2,
			[ProtoEnum(Name = "Skill", Value = 3)]
			Skill = 3
		}

		private TypeEnum _Type;

		private List<int> _Indexs;

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

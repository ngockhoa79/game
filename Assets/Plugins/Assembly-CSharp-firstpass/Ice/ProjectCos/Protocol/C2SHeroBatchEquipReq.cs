using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroBatchEquipReq")]
	public class C2SHeroBatchEquipReq : IExtensible
	{
		private int _Index;

		private List<int> _Skills;

		private List<int> _Equipments;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(2, Name = "Skills", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skills

		{

			get => _Skills;

			set => _Skills = value;

		}

		[ProtoMember(3, Name = "Equipments", DataFormat = DataFormat.TwosComplement)]
		public List<int> Equipments

		{

			get => _Equipments;

			set => _Equipments = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.TwosComplement)]
		public int CrossType
		{
			get => _CrossType;
			set => _CrossType = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

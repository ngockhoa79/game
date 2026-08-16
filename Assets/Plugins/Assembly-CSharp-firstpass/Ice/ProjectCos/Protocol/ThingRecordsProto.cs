using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ThingRecordsProto")]
	public class ThingRecordsProto : IExtensible
	{
		private List<int> _Heros;

		private List<int> _Equipments;

		private List<int> _Skills;

		private List<int> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Heros", DataFormat = DataFormat.TwosComplement)]
		public List<int> Heros

		{

			get => _Heros;

			set => _Heros = value;

		}

		[ProtoMember(2, Name = "Equipments", DataFormat = DataFormat.TwosComplement)]
		public List<int> Equipments

		{

			get => _Equipments;

			set => _Equipments = value;

		}

		[ProtoMember(3, Name = "Skills", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skills

		{

			get => _Skills;

			set => _Skills = value;

		}

		[ProtoMember(4, Name = "Items", DataFormat = DataFormat.TwosComplement)]
		public List<int> Items

		{

			get => _Items;

			set => _Items = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

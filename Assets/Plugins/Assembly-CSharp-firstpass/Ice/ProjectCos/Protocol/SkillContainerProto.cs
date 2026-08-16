using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "SkillContainerProto")]
	public class SkillContainerProto : IExtensible
	{
		private List<ItemInfoProto> _Items;

		private int _MaxSkillCount;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ItemInfoProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "MaxSkillCount", DataFormat = DataFormat.TwosComplement)]
		public int MaxSkillCount
		{
			get => _MaxSkillCount;
			set => _MaxSkillCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

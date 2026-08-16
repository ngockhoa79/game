using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateDropProto")]
	public class DuplicateDropProto : IExtensible
	{
		private int _FighterId;

		private ItemChangeProto _Item;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FighterId", DataFormat = DataFormat.TwosComplement)]
		public int FighterId
		{
			get => _FighterId;
			set => _FighterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Item", DataFormat = DataFormat.Default)]
		public ItemChangeProto Item
		{
			get => _Item;
			set => _Item = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

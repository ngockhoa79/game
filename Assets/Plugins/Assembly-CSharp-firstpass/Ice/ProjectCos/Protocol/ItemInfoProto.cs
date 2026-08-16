using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ItemInfoProto")]
	public class ItemInfoProto : IExtensible
	{
		private int _Id;

		private int _Index;

		private int _Number;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Number", DataFormat = DataFormat.TwosComplement)]
		public int Number
		{
			get => _Number;
			set => _Number = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

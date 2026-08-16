using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PositionInfo")]
	public class PositionInfo : IExtensible
	{
		private int _Index;

		private int _BondID;

		private int _Level;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "BondID", DataFormat = DataFormat.TwosComplement)]
		public int BondID
		{
			get => _BondID;
			set => _BondID = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

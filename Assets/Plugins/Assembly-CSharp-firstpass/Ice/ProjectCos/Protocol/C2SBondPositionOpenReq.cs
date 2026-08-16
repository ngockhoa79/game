using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SBondPositionOpenReq")]
	public class C2SBondPositionOpenReq : IExtensible
	{
		private int _PosionIndex;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PosionIndex", DataFormat = DataFormat.TwosComplement)]
		public int PosionIndex
		{
			get => _PosionIndex;
			set => _PosionIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.TwosComplement)]
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

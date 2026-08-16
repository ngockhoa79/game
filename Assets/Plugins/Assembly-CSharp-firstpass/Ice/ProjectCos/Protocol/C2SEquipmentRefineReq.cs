using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SEquipmentRefineReq")]
	public class C2SEquipmentRefineReq : IExtensible
	{
		private int _Index;

		private EquipmentItemProto.LockCodeEnum _Lock;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Lock", DataFormat = DataFormat.TwosComplement)]
		public EquipmentItemProto.LockCodeEnum Lock
		{
			get
			{
				return default(EquipmentItemProto.LockCodeEnum);
			}
			set
			{
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

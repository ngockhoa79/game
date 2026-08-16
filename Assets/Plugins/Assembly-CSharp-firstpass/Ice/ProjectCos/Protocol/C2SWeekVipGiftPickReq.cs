using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SWeekVipGiftPickReq")]
	public class C2SWeekVipGiftPickReq : IExtensible
	{
		private int _Index;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

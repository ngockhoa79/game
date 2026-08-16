using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CChargeSuccessNtf")]
	public class S2CChargeSuccessNtf : IExtensible
	{
		private int _Id;

		private int _Crystal;

		private bool _IsFirstCharge;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public int Crystal
		{
			get => _Crystal;
			set => _Crystal = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsFirstCharge", DataFormat = DataFormat.Default)]
		public bool IsFirstCharge
		{
			get => _IsFirstCharge;
			set => _IsFirstCharge = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

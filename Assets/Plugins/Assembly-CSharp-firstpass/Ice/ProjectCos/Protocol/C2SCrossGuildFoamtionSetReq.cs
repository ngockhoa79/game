using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SCrossGuildFoamtionSetReq")]
	public class C2SCrossGuildFoamtionSetReq : IExtensible
	{
		private int _RowIndex;

		private int _ColunmIndex;

		private bool _IsUp;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "RowIndex", DataFormat = DataFormat.TwosComplement)]
		public int RowIndex
		{
			get => _RowIndex;
			set => _RowIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ColunmIndex", DataFormat = DataFormat.TwosComplement)]
		public int ColunmIndex
		{
			get => _ColunmIndex;
			set => _ColunmIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "IsUp", DataFormat = DataFormat.Default)]
		public bool IsUp
		{
			get => _IsUp;
			set => _IsUp = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

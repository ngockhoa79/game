using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SCrossPersonPlayOffGetFormationReq")]
	public class C2SCrossPersonPlayOffGetFormationReq : IExtensible
	{
		private int _Index;

		private string _Id;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Id", DataFormat = DataFormat.Default)]
		public string Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.Default)]
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

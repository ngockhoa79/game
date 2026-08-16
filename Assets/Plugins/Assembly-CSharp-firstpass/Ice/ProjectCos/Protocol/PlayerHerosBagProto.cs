using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerHerosBagProto")]
	public class PlayerHerosBagProto : IExtensible
	{
		private int _MaxCount;

		private List<PlayerHeroInfoProto> _HerosInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MaxCount", DataFormat = DataFormat.TwosComplement)]
		public int MaxCount
		{
			get => _MaxCount;
			set => _MaxCount = value;
		}

		[ProtoMember(2, Name = "HerosInfo", DataFormat = DataFormat.Default)]
		public List<PlayerHeroInfoProto> HerosInfo

		{

			get => _HerosInfo;

			set => _HerosInfo = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

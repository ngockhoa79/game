using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CHeroInfoChangeNtf")]
	public class S2CHeroInfoChangeNtf : IExtensible
	{
		private PlayerHeroInfoProto _heroInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "heroInfo", DataFormat = DataFormat.Default)]
		public PlayerHeroInfoProto HeroInfo
		{
			get
			{
				return null;
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

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGameStateMatchErrorNtf")]
	public class S2CGameStateMatchErrorNtf : IExtensible
	{
		private string _Info;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public string Info
		{
			get => _Info;
			set => _Info = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

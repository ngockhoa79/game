using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildSearchForReq")]
	public class C2SGuildSearchForReq : IExtensible
	{
		private string _GuildSignString;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "GuildSignString", DataFormat = DataFormat.Default)]
		public string GuildSignString
		{
			get => _GuildSignString;
			set => _GuildSignString = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

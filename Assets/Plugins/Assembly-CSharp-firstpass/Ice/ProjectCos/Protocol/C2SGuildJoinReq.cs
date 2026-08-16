using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildJoinReq")]
	public class C2SGuildJoinReq : IExtensible
	{
		private int _GuildId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.TwosComplement)]
		public int GuildId
		{
			get => _GuildId;
			set => _GuildId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

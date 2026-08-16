using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SChatReq")]
	public class C2SChatReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "World", Value = 0)]
			World = 0,
			[ProtoEnum(Name = "Guild", Value = 1)]
			Guild = 1,
			[ProtoEnum(Name = "GuildInvite", Value = 2)]
			GuildInvite = 2
		}

		private TypeEnum _Type;

		private string _Message;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Message", DataFormat = DataFormat.Default)]
		public string Message
		{
			get => _Message;
			set => _Message = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

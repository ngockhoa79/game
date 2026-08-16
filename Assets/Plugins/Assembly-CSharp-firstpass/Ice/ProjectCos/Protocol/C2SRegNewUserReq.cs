using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRegNewUserReq")]
	public class C2SRegNewUserReq : IExtensible
	{
		private string _NewUserName;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "NewUserName", DataFormat = DataFormat.Default)]
		public string NewUserName
		{
			get => _NewUserName;
			set => _NewUserName = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SSettingMarkReq")]
	public class C2SSettingMarkReq : IExtensible
	{
		private SettingProto.SettingEnum _Id;

		private bool _IsOn;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public SettingProto.SettingEnum Id
		{
			get
			{
				return default(SettingProto.SettingEnum);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "IsOn", DataFormat = DataFormat.Default)]
		public bool IsOn
		{
			get => _IsOn;
			set => _IsOn = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

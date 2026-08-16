using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SAchievementPickReq")]
	public class C2SAchievementPickReq : IExtensible
	{
		private int _AchievementId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "AchievementId", DataFormat = DataFormat.TwosComplement)]
		public int AchievementId
		{
			get => _AchievementId;
			set => _AchievementId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

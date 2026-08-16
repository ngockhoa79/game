using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SSkillCombineReq")]
	public class C2SSkillCombineReq : IExtensible
	{
		private int _SkillId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SkillId", DataFormat = DataFormat.TwosComplement)]
		public int SkillId
		{
			get => _SkillId;
			set => _SkillId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

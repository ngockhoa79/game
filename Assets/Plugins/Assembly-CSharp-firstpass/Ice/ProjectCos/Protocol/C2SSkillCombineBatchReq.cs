using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SSkillCombineBatchReq")]
	public class C2SSkillCombineBatchReq : IExtensible
	{
		private List<int> _SkillIds;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "SkillIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> SkillIds

		{

			get => _SkillIds;

			set => _SkillIds = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

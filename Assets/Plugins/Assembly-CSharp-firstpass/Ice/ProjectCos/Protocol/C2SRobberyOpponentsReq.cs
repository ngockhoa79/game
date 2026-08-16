using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRobberyOpponentsReq")]
	public class C2SRobberyOpponentsReq : IExtensible
	{
		private int _skillChipId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "skillChipId", DataFormat = DataFormat.TwosComplement)]
		public int SkillChipId
		{
			get
			{
				return 0;
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

using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2STrialStartBattleReq")]
	public class C2STrialStartBattleReq : IExtensible
	{
		private int _SuperSatgeId;

		private List<int> _ReplaceColumnIndexs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SuperSatgeId", DataFormat = DataFormat.TwosComplement)]
		public int SuperSatgeId
		{
			get => _SuperSatgeId;
			set => _SuperSatgeId = value;
		}

		[ProtoMember(2, Name = "ReplaceColumnIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReplaceColumnIndexs

		{

			get => _ReplaceColumnIndexs;

			set => _ReplaceColumnIndexs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FighterDeadProto")]
	public class FighterDeadProto : IExtensible
	{
		private int _FighterId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FighterId", DataFormat = DataFormat.TwosComplement)]
		public int FighterId
		{
			get => _FighterId;
			set => _FighterId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

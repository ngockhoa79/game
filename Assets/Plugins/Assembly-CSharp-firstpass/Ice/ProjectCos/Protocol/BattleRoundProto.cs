using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BattleRoundProto")]
	public class BattleRoundProto : IExtensible
	{
		private List<BattleActionProto> _Actions;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Actions", DataFormat = DataFormat.Default)]
		public List<BattleActionProto> Actions

		{

			get => _Actions;

			set => _Actions = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

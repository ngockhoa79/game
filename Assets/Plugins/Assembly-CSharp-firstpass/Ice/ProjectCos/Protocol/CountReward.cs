using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CountReward")]
	public class CountReward : IExtensible
	{
		private List<ThingProto> _Rewards;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Rewards", DataFormat = DataFormat.Default)]
		public List<ThingProto> Rewards

		{

			get => _Rewards;

			set => _Rewards = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

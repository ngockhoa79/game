using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GiftReward")]
	public class GiftReward : IExtensible
	{
		private int _Sale;

		private int _Original;

		private List<ThingProto> _Rewards;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Sale", DataFormat = DataFormat.TwosComplement)]
		public int Sale
		{
			get => _Sale;
			set => _Sale = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Original", DataFormat = DataFormat.TwosComplement)]
		public int Original
		{
			get => _Original;
			set => _Original = value;
		}

		[ProtoMember(3, Name = "Rewards", DataFormat = DataFormat.Default)]
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

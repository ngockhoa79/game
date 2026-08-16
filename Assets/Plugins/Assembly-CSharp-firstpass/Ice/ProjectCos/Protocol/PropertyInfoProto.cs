using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PropertyInfoProto")]
	public class PropertyInfoProto : IExtensible
	{
		[ProtoContract(Name = "PropertyType")]
		public enum PropertyType
		{
			[ProtoEnum(Name = "Energy", Value = 2)]
			Energy = 2,
			[ProtoEnum(Name = "Friendship", Value = 3)]
			Friendship = 3,
			[ProtoEnum(Name = "Gold", Value = 4)]
			Gold = 4,
			[ProtoEnum(Name = "Crystal", Value = 5)]
			Crystal = 5,
			[ProtoEnum(Name = "Exp", Value = 6)]
			Exp = 6,
			[ProtoEnum(Name = "Reputation", Value = 7)]
			Reputation = 7,
			[ProtoEnum(Name = "TrialCoin", Value = 8)]
			TrialCoin = 8,
			[ProtoEnum(Name = "TransmitSoul", Value = 9)]
			TransmitSoul = 9,
			[ProtoEnum(Name = "GuildContribution", Value = 10)]
			GuildContribution = 10,
			[ProtoEnum(Name = "CourageProof", Value = 11)]
			CourageProof = 11
		}

		private PropertyType _Type;

		private int _Count;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public PropertyType Type
		{
			get
			{
				return default(PropertyType);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

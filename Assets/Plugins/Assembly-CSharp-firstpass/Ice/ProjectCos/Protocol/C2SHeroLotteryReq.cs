using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroLotteryReq")]
	public class C2SHeroLotteryReq : IExtensible
	{
		[ProtoContract(Name = "LotteryType")]
		public enum LotteryType
		{
			[ProtoEnum(Name = "Friendship", Value = 0)]
			Friendship = 0,
			[ProtoEnum(Name = "Diamond", Value = 2)]
			Diamond = 2,
			[ProtoEnum(Name = "DiamondTen", Value = 3)]
			DiamondTen = 3
		}

		private LotteryType _Type;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public LotteryType Type
		{
			get => _Type;
			set => _Type = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SBuyFunctionReq")]
	public class C2SBuyFunctionReq : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Energy", Value = 1)]
			Energy = 1,
			[ProtoEnum(Name = "PVPChallengeTimes", Value = 2)]
			PVPChallengeTimes = 2,
			[ProtoEnum(Name = "PVPSendRedPackTimes", Value = 3)]
			PVPSendRedPackTimes = 3,
			[ProtoEnum(Name = "Gold", Value = 4)]
			Gold = 4,
			[ProtoEnum(Name = "BuyHeroBagSize", Value = 5)]
			BuyHeroBagSize = 5,
			[ProtoEnum(Name = "ClearPVPChallengeCDTime", Value = 6)]
			ClearPVPChallengeCDTime = 6,
			[ProtoEnum(Name = "RobberyTimes", Value = 7)]
			RobberyTimes = 7,
			[ProtoEnum(Name = "GuildSendRedPackTimes", Value = 8)]
			GuildSendRedPackTimes = 8,
			[ProtoEnum(Name = "BuySkillBagSize", Value = 9)]
			BuySkillBagSize = 9,
			[ProtoEnum(Name = "BuyEquipBagSize", Value = 10)]
			BuyEquipBagSize = 10
		}

		private TypeEnum _Type;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public TypeEnum Type
		{
			get
			{
				return default(TypeEnum);
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

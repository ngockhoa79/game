using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BattleActionProto")]
	public class BattleActionProto : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "NormalAttack", Value = 1)]
			NormalAttack = 1,
			[ProtoEnum(Name = "SkillEffect", Value = 2)]
			SkillEffect = 2,
			[ProtoEnum(Name = "BuffActionEffect", Value = 3)]
			BuffActionEffect = 3,
			[ProtoEnum(Name = "BuffDelete", Value = 4)]
			BuffDelete = 4,
			[ProtoEnum(Name = "ToNewLine", Value = 5)]
			ToNewLine = 5,
			[ProtoEnum(Name = "GroupRemainAddHp", Value = 6)]
			GroupRemainAddHp = 6,
			[ProtoEnum(Name = "FinalCompetition", Value = 7)]
			FinalCompetition = 7,
			[ProtoEnum(Name = "FinalCompetitionAddSpirit", Value = 8)]
			FinalCompetitionAddSpirit = 8,
			[ProtoEnum(Name = "TurnOverSign", Value = 9)]
			TurnOverSign = 9,
			[ProtoEnum(Name = "FightStartSign", Value = 10)]
			FightStartSign = 10,
			[ProtoEnum(Name = "RoundOver", Value = 11)]
			RoundOver = 11,
			[ProtoEnum(Name = "EnterBattle", Value = 12)]
			EnterBattle = 12,
			[ProtoEnum(Name = "BuffAdd", Value = 13)]
			BuffAdd = 13
		}

		private int _Type;

		private byte[] _Data;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public int Type
		{
			get => _Type;
			set => _Type = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Data", DataFormat = DataFormat.Default)]
		public byte[] Data
		{
			get => _Data;
			set => _Data = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PropertyChangeProto")]
	public class PropertyChangeProto : IExtensible
	{
		[ProtoContract(Name = "TypeEnum")]
		public enum TypeEnum
		{
			[ProtoEnum(Name = "Hp", Value = 1)]
			Hp = 1,
			[ProtoEnum(Name = "Attack", Value = 2)]
			Attack = 2,
			[ProtoEnum(Name = "Defense", Value = 3)]
			Defense = 3,
			[ProtoEnum(Name = "Spirit", Value = 4)]
			Spirit = 4,
			[ProtoEnum(Name = "Speed", Value = 5)]
			Speed = 5,
			[ProtoEnum(Name = "Crit", Value = 6)]
			Crit = 6,
			[ProtoEnum(Name = "AntiCrit", Value = 7)]
			AntiCrit = 7,
			[ProtoEnum(Name = "Batter", Value = 8)]
			Batter = 8,
			[ProtoEnum(Name = "AntiBatter", Value = 9)]
			AntiBatter = 9,
			[ProtoEnum(Name = "Miss", Value = 10)]
			Miss = 10,
			[ProtoEnum(Name = "AntiMiss", Value = 11)]
			AntiMiss = 11,
			[ProtoEnum(Name = "Block", Value = 12)]
			Block = 12,
			[ProtoEnum(Name = "AntiBlock", Value = 13)]
			AntiBlock = 13
		}

		private int _Type;

		private int _TargetFighterId;

		private int _Value;

		private bool _IsDead;

		private int _FinalValue;

		private int _BeforeValue;

		private int _AfterHp;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public int Type
		{
			get => _Type;
			set => _Type = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TargetFighterId", DataFormat = DataFormat.TwosComplement)]
		public int TargetFighterId
		{
			get => _TargetFighterId;
			set => _TargetFighterId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Value", DataFormat = DataFormat.TwosComplement)]
		public int Value
		{
			get => _Value;
			set => _Value = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsDead", DataFormat = DataFormat.Default)]
		public bool IsDead
		{
			get => _IsDead;
			set => _IsDead = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "FinalValue", DataFormat = DataFormat.TwosComplement)]
		public int FinalValue
		{
			get => _FinalValue;
			set => _FinalValue = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "BeforeValue", DataFormat = DataFormat.TwosComplement)]
		public int BeforeValue
		{
			get => _BeforeValue;
			set => _BeforeValue = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "AfterHp", DataFormat = DataFormat.TwosComplement)]
		public int AfterHp
		{
			get => _AfterHp;
			set => _AfterHp = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

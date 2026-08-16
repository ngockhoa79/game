using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerHeroPropertyInfoProto")]
	public class PlayerHeroPropertyInfoProto : IExtensible
	{
		private int _Id;

		private int _Index;

		private HeroPropertyItemProto _Hp;

		private HeroPropertyItemProto _Attack;

		private HeroPropertyItemProto _Defense;

		private HeroPropertyItemProto _Spirit;

		private HeroPropertyItemProto _Speed;

		private HeroPropertyItemProto _Crit;

		private HeroPropertyItemProto _AntiCrit;

		private HeroPropertyItemProto _Miss;

		private HeroPropertyItemProto _AntiMiss;

		private HeroPropertyItemProto _Block;

		private HeroPropertyItemProto _AntiBlock;

		private HeroPropertyItemProto _Batter;

		private HeroPropertyItemProto _AntiBatter;

		private int _Level;

		private int _ExpTotal;

		private int _Potential;

		private int _CombatValue;

		private bool _IsLocked;

		private int _GasLevel;

		private int _GasMaterialMark;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Hp", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Hp
		{
			get => _Hp;
			set => _Hp = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Attack", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Attack
		{
			get => _Attack;
			set => _Attack = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Defense", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Defense
		{
			get => _Defense;
			set => _Defense = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Spirit", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Spirit
		{
			get => _Spirit;
			set => _Spirit = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "Speed", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Speed
		{
			get => _Speed;
			set => _Speed = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "Crit", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Crit
		{
			get => _Crit;
			set => _Crit = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "AntiCrit", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto AntiCrit
		{
			get => _AntiCrit;
			set => _AntiCrit = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "Miss", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Miss
		{
			get => _Miss;
			set => _Miss = value;
		}

		[ProtoMember(11, IsRequired = true, Name = "AntiMiss", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto AntiMiss
		{
			get => _AntiMiss;
			set => _AntiMiss = value;
		}

		[ProtoMember(12, IsRequired = true, Name = "Block", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Block
		{
			get => _Block;
			set => _Block = value;
		}

		[ProtoMember(13, IsRequired = true, Name = "AntiBlock", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto AntiBlock
		{
			get => _AntiBlock;
			set => _AntiBlock = value;
		}

		[ProtoMember(14, IsRequired = true, Name = "Batter", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto Batter
		{
			get => _Batter;
			set => _Batter = value;
		}

		[ProtoMember(15, IsRequired = true, Name = "AntiBatter", DataFormat = DataFormat.Default)]
		public HeroPropertyItemProto AntiBatter
		{
			get => _AntiBatter;
			set => _AntiBatter = value;
		}

		[ProtoMember(16, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get => _Level;
			set => _Level = value;
		}

		[ProtoMember(17, IsRequired = true, Name = "ExpTotal", DataFormat = DataFormat.TwosComplement)]
		public int ExpTotal
		{
			get => _ExpTotal;
			set => _ExpTotal = value;
		}

		[ProtoMember(18, IsRequired = true, Name = "Potential", DataFormat = DataFormat.TwosComplement)]
		public int Potential
		{
			get => _Potential;
			set => _Potential = value;
		}

		[ProtoMember(19, IsRequired = true, Name = "CombatValue", DataFormat = DataFormat.TwosComplement)]
		public int CombatValue
		{
			get => _CombatValue;
			set => _CombatValue = value;
		}

		[ProtoMember(20, IsRequired = true, Name = "IsLocked", DataFormat = DataFormat.Default)]
		public bool IsLocked
		{
			get => _IsLocked;
			set => _IsLocked = value;
		}

		[ProtoMember(21, IsRequired = true, Name = "GasLevel", DataFormat = DataFormat.TwosComplement)]
		public int GasLevel
		{
			get => _GasLevel;
			set => _GasLevel = value;
		}

		[ProtoMember(22, IsRequired = true, Name = "GasMaterialMark", DataFormat = DataFormat.TwosComplement)]
		public int GasMaterialMark
		{
			get => _GasMaterialMark;
			set => _GasMaterialMark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Hero : ItemHolding
	{
		public enum CardStatusType
		{
			Normal = 0,
			OnField = 1,
			Locked = 2,
			_NUM = 3
		}

		[CompilerGenerated]
		private sealed class _003Cget_Gears_003Ed__39 : IEnumerable<GearHolding>, IEnumerable, IEnumerator<GearHolding>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GearHolding _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Hero _003C_003E4__this;

			private GearHolding[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			GearHolding IEnumerator<GearHolding>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Gears_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<GearHolding> IEnumerable<GearHolding>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_Skills_003Ed__49 : IEnumerable<SkillHolding>, IEnumerable, IEnumerator<SkillHolding>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private SkillHolding _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Hero _003C_003E4__this;

			private SkillHolding[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			SkillHolding IEnumerator<SkillHolding>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Skills_003Ed__49(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<SkillHolding> IEnumerable<SkillHolding>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private bool isFromSupporters;

		public readonly Attribute Health;

		public readonly Attribute Defence;

		public readonly Attribute Attack;

		public readonly Attribute Spirit;

		public readonly Attribute Speed;

		public readonly Attribute Critical;

		public readonly Attribute AntiCritical;

		public readonly Attribute Combo;

		public readonly Attribute AntiCombo;

		public readonly Attribute Miss;

		public readonly Attribute AntiMiss;

		public readonly Attribute Block;

		public readonly Attribute AntiBlock;

		public const int GearCount = 4;

		private readonly GearHolding[] gears;

		public Skill Talent;

		public const int EquipableSkillCount = 3;

		private readonly SkillHolding[] skills;

		public int Level;

		public int Power;

		public int ExpTotal;

		public int Potential;

		public int GasLevel;

		public int GasMaterialMark;

		public int _cardStatus;

		public new bool CartStatus;

		private HeroConfig _config;

		public HeroConfig Config => _config;

		public Player Owner { get; set; }

		public bool IsSupporter => false;

		public override int SellingPrice => 0;

		public IEnumerable<GearHolding> Gears
		{
			[IteratorStateMachine(typeof(_003Cget_Gears_003Ed__39))]
			get
			{
				return null;
			}
		}

		public Skill LeaderSkill => null;

		public IEnumerable<SkillHolding> Skills
		{
			[IteratorStateMachine(typeof(_003Cget_Skills_003Ed__49))]
			get
			{
				return null;
			}
		}

		public int PowerInt => 0;

		public int CardStatus => 0;

		public bool IsOnField => false;

		public void MarkHeroAsSupporter()
		{
		}

		public Hero(HeroConfig config, Player owner, int localID)
			: base(config, 1, localID)
		{
			_config = config;
			Owner = owner;
			LocalID = localID;

			Health = new Attribute(EAttrType.Health);
			Defence = new Attribute(EAttrType.Defence);
			Attack = new Attribute(EAttrType.Attack);
			Spirit = new Attribute(EAttrType.Spirit);
			Speed = new Attribute(EAttrType.Speed);
			Critical = new Attribute(EAttrType.Critical);
			AntiCritical = new Attribute(EAttrType.AntiCritical);
			Combo = new Attribute(EAttrType.Combo);
			AntiCombo = new Attribute(EAttrType.AntiCombo);
			Miss = new Attribute(EAttrType.Miss);
			AntiMiss = new Attribute(EAttrType.AntiMiss);
			Block = new Attribute(EAttrType.Block);
			AntiBlock = new Attribute(EAttrType.AntiBlock);

			gears = new GearHolding[GearCount];
			skills = new SkillHolding[EquipableSkillCount];
		}

		public void PatchAdditionalSkills(int[] ids)
		{
		}

		private int GetEatGold(int totalExp)
		{
			return 0;
		}

		private double GetHeroEatCost(ERarity rarity, int star)
		{
			return 0.0;
		}

		private int GetHeroIndex(ERarity rarityType, int star)
		{
			return 0;
		}

		public Attribute GetAttr(int attrId)
		{
			return GetAttr((EAttrType)attrId);
		}

		public Attribute GetAttr(string attrName)
		{
			if (Enum.TryParse<EAttrType>(attrName, out var type))
			{
				return GetAttr(type);
			}
			return null;
		}

		public Attribute GetAttr(EAttrType attrType)
		{
			switch (attrType)
			{
				case EAttrType.Health: return Health;
				case EAttrType.Attack: return Attack;
				case EAttrType.Defence: return Defence;
				case EAttrType.Spirit: return Spirit;
				case EAttrType.Speed: return Speed;
				case EAttrType.Critical: return Critical;
				case EAttrType.AntiCritical: return AntiCritical;
				case EAttrType.Combo: return Combo;
				case EAttrType.AntiCombo: return AntiCombo;
				case EAttrType.Miss: return Miss;
				case EAttrType.AntiMiss: return AntiMiss;
				case EAttrType.Block: return Block;
				case EAttrType.AntiBlock: return AntiBlock;
				default: return null;
			}
		}

		public override void AddToMe()
		{
		}

		public GearHolding GetGear(EGearSlot slot)
		{
			return null;
		}

		public void SetGear(EGearSlot slot, GearHolding holding)
		{
		}

		public SkillHolding GetSkill(int slot)
		{
			return null;
		}

		public int GetSkillSlotIndex(SkillHolding holding)
		{
			return 0;
		}

		public void SetSkill(int slot, SkillHolding holding)
		{
		}

		public void TakeOffTillNaked()
		{
		}

		private void takeOffAllSkills()
		{
		}

		private void takeOffAllGears()
		{
		}

		public static Hero CreateFromProto(PlayerHeroInfoProto proto, Player owner)
		{
			if (proto == null || proto.PropertyBaseInfo == null) return null;
			HeroConfig config = HeroConfig.Get(proto.PropertyBaseInfo.Id);
			Hero hero = new Hero(config, owner, proto.PropertyBaseInfo.Index);
			hero.FromProto(proto);
			return hero;
		}

		public void FromProto(PlayerHeroInfoProto proto)
		{
			if (proto == null || proto.PropertyBaseInfo == null) return;
			var baseInfo = proto.PropertyBaseInfo;

			LocalID = baseInfo.Index;
			Level = baseInfo.Level;
			ExpTotal = baseInfo.ExpTotal;
			Potential = baseInfo.Potential;
			Power = baseInfo.CombatValue;
			GasLevel = baseInfo.GasLevel;
			GasMaterialMark = baseInfo.GasMaterialMark;
			_cardStatus = baseInfo.IsLocked ? 1 : 0;

			if (Health != null) Health.FromProto(baseInfo.Hp);
			if (Attack != null) Attack.FromProto(baseInfo.Attack);
			if (Defence != null) Defence.FromProto(baseInfo.Defense);
			if (Spirit != null) Spirit.FromProto(baseInfo.Spirit);
			if (Speed != null) Speed.FromProto(baseInfo.Speed);
			if (Critical != null) Critical.FromProto(baseInfo.Crit);
			if (AntiCritical != null) AntiCritical.FromProto(baseInfo.AntiCrit);
			if (Combo != null) Combo.FromProto(baseInfo.Batter);
			if (AntiCombo != null) AntiCombo.FromProto(baseInfo.AntiBatter);
			if (Miss != null) Miss.FromProto(baseInfo.Miss);
			if (AntiMiss != null) AntiMiss.FromProto(baseInfo.AntiMiss);
			if (Block != null) Block.FromProto(baseInfo.Block);
			if (AntiBlock != null) AntiBlock.FromProto(baseInfo.AntiBlock);

			if (proto.Skills != null && proto.Skills.Count > 0)
			{
				Talent = Skill.Get(proto.Skills[0].Id);
				for (int i = 1; i < proto.Skills.Count && i <= EquipableSkillCount; i++)
				{
					var s = proto.Skills[i];
					skills[i - 1] = new SkillHolding(Skill.Get(s.Id), s.Index);
				}
			}

			if (proto.Equips != null)
			{
				for (int i = 0; i < proto.Equips.Count && i < GearCount; i++)
				{
					var eq = proto.Equips[i];
					gears[i] = new GearHolding(Gear.Get(eq.Id), eq.Index);
				}
			}
		}

		public void FromTemplate()
		{
			if (Config == null) return;
			Level = Config.BaseLevel;
			if (Config.Template != null)
			{
				if (Health != null) Health.FromTemplate(Config.Template.HpProperty);
				if (Defence != null) Defence.FromTemplate(Config.Template.DefenseProperty);
				if (Attack != null) Attack.FromTemplate(Config.Template.AttackProperty);
				if (Spirit != null) Spirit.FromTemplate(Config.Template.SpiritProperty);
				if (Speed != null) Speed.FromTemplate(Config.Template.SpeedProperty);
				if (Critical != null) Critical.FromTemplate(Config.Template.CritProperty);
				if (AntiCritical != null) AntiCritical.FromTemplate(Config.Template.AntiCritProperty);
				if (Combo != null) Combo.FromTemplate(Config.Template.BatterProperty);
				if (AntiCombo != null) AntiCombo.FromTemplate(Config.Template.AntiBatterProperty);
				if (Miss != null) Miss.FromTemplate(Config.Template.MissProperty);
				if (AntiMiss != null) AntiMiss.FromTemplate(Config.Template.AntiMissProperty);
				if (Block != null) Block.FromTemplate(Config.Template.BlockProperty);
				if (AntiBlock != null) AntiBlock.FromTemplate(Config.Template.AntiBlockProperty);
			}
		}

		public void SetLock()
		{
		}

		public void ClearLock()
		{
		}

		public bool GetLockStatus()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public void ModifyOwner(Player newOwner)
		{
		}

		public bool CanShowRedDot(int t)
		{
			return false;
		}

		public bool CanShowRedDot(EGearSlot s)
		{
			return false;
		}

		public bool CanShowRedDot()
		{
			return false;
		}

		public bool CanGasEquipItem()
		{
			return false;
		}

		public bool CanShowUpgradeTip()
		{
			return false;
		}

		public Skill GetLeaderSkill()
		{
			return null;
		}

		public Skill GetAssistantSkill()
		{
			return null;
		}
	}
}

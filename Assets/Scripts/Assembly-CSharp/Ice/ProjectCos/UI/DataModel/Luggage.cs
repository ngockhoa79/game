using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Luggage
	{
		public enum SkillFilter
		{
			Default = 0,
			Quality = 1,
			Star = 2,
			Type = 3,
			_NUM = 4
		}

		public enum GearFilter
		{
			Default = 0,
			Quality = 1,
			Level = 2,
			Position = 3,
			_NUM = 4
		}

		public readonly MonintoredList<ItemHolding> CardFragments;

		public readonly MonintoredList<ItemHolding> Gears;

		public readonly MonintoredList<ItemHolding> GearFormulas;

		public readonly MonintoredList<ItemHolding> Skills;

		public readonly MonintoredList<ItemHolding> SkillFragments;

		public readonly MonintoredList<ItemHolding> SkillStones;

		public readonly MonintoredList<ItemHolding> GearStones;

		public readonly MonintoredList<ItemHolding> RefineStones;

		public readonly MonintoredList<ItemHolding> Consumables;

		public readonly Dictionary<Skill, List<SkillFragmentContent>> SkillFragmentPackage;

		public SkillHolding[] SkillUpgradeMaterials;

		public int[] SkillUpgradeBooks;

		public int[] SkillUpgradeStones;

		public SkillFilter skillFilter;

		public GearFilter gearFilter;

		private bool HasSkillCanCombine => false;

		public void ClearSkillUpgradeMaterials()
		{
		}

		public void Clear()
		{
		}

		public void ClearSkillUpgradeStones()
		{
		}

		public void FromProto(PlayerBagInfoProto proto)
		{
		}

		private void fromProto(HeroChipContainerProto proto)
		{
		}

		private void fromProto(EquipmentContainerProto proto)
		{
		}

		private void fromProto(EquipmentChipContainerProto proto)
		{
		}

		private void fromProto(SkillContainerProto proto)
		{
		}

		private void fromProto(SkillChipContainerProto proto)
		{
		}

		private void fromProto(ConsumeContainerProto proto)
		{
		}

		public MonintoredList<ItemHolding> GetList(AbstractItem item)
		{
			return null;
		}

		public ItemHolding GetHolding(MonintoredList<ItemHolding> list, int localID)
		{
			return null;
		}

		public ItemHolding GetOneHolding(AbstractItem item)
		{
			return null;
		}

		public List<ItemHolding> GetHoldings(AbstractItem item)
		{
			return null;
		}

		public int GetHoldingCount(AbstractItem item)
		{
			return 0;
		}

		public int GetGasHoldingCount(AbstractItem item)
		{
			return 0;
		}

		public bool isEquipItemHolding(ItemHolding holding)
		{
			return false;
		}

		private MonintoredList<ItemHolding> getList(ItemChangeProto proto)
		{
			return null;
		}

		public static ItemHolding CreateHolding(ItemChangeProto proto)
		{
			return null;
		}

		public static ItemHolding CreateHolding(SimpleItem proto)
		{
			return null;
		}

		public ThingHolding ApplyChange(ItemChangeProto change)
		{
			return null;
		}

		public ItemHolding ApplyChange(ItemHolding change)
		{
			return null;
		}

		public void ApplyChangeItemProtos(List<ItemChangeProto> protos)
		{
		}

		public void AddItem(ItemHolding itemAdd)
		{
		}

		public void AddGear(GearHolding gh)
		{
		}

		public void AddSkill(SkillHolding sh)
		{
		}

		public void RemoveSkill(SkillHolding sh)
		{
		}

		public GearHolding BuildGearHoldingFromProto(EquipmentItemProto proto)
		{
			return null;
		}

		public void ApplyChangeByGearHolding(GearHolding holding)
		{
		}

		public void ApplyChangeBySkillHolding(SkillHolding holding)
		{
		}

		public void RefreshSkillFragmentList()
		{
		}

		public List<ItemHolding> FilteredCardFragmentsList()
		{
			return null;
		}

		public ItemHolding GetSkillStones(ERarity rarity)
		{
			return null;
		}

		public ItemHolding GetRefineStones(ERarity rarity)
		{
			return null;
		}

		public int GetRefineStoneCount()
		{
			return 0;
		}

		public List<ItemHolding> GetAllRefineStoneItems()
		{
			return null;
		}

		public ItemHolding GetGearStones(ERarity rarity)
		{
			return null;
		}

		public List<SkillHolding> FilteredSkillList()
		{
			return null;
		}

		public List<SkillHolding> FilteredSkillList(bool addArmerdSkill, ERarity[] forbitRatity, SkillFilter sortType = SkillFilter.Default)
		{
			return null;
		}

		public List<ItemHolding> FilteredGearList()
		{
			return null;
		}

		public void MarkAllNewGearOff()
		{
		}

		public void MarkAllNewSkillOff()
		{
		}

		private List<ItemHolding> filterForGearSlot(List<GearHolding> src, EGearSlot GearSlotType)
		{
			return null;
		}

		private void filterItemRarity(List<SkillHolding> src, ERarity[] forbitRatity)
		{
		}

		private void filterItemRarity(List<ItemHolding> src, ERarity[] forbitRatity)
		{
		}

		public List<ItemHolding> FilterForGearList(bool addArmerdGear, int gearSlotInt, ERarity[] forbitRatity, GearFilter sortType = GearFilter.Default)
		{
			return null;
		}

		public List<ItemHolding> SortedGearFragments()
		{
			return null;
		}

		public List<ItemHolding> SortedCardFragments()
		{
			return null;
		}

		public bool CheckHeroFragmentCanSummon()
		{
			return false;
		}

		public bool CheckGearFragmentCanFore()
		{
			return false;
		}

		public bool CheckSkillFragmentCanFore()
		{
			return false;
		}

		public bool CheckNewCard()
		{
			return false;
		}

		public bool CheckNewGear()
		{
			return false;
		}

		public bool CheckNewSkill()
		{
			return false;
		}

		public void UnloadSkillHolding(SkillHolding sh)
		{
		}

		public void UnloadGearHolding(GearHolding gh)
		{
		}
	}
}

using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeSorting : MonoBehaviour
{
	public class RarityComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class RarityUpComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class StarComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class StarUpComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class RankComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class RankUpComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class HeroRarityComparator : IComparer<Hero>
	{
		private int symbol;

		public HeroRarityComparator(bool isHighToLow = true)
		{
		}

		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class HeroStarComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class HeroLevelComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class HeroProfComparator : IComparer<Hero>
	{
		public int Compare(Hero a, Hero b)
		{
			return 0;
		}
	}

	public class SkillRarityComparator : IComparer<SkillHolding>
	{
		private int symbol;

		public SkillRarityComparator(bool isHighToLow)
		{
		}

		public int Compare(SkillHolding a, SkillHolding b)
		{
			return 0;
		}
	}

	public class SkillStarComparator : IComparer<SkillHolding>
	{
		public int Compare(SkillHolding a, SkillHolding b)
		{
			return 0;
		}
	}

	public class SkillTypeComparator : IComparer<SkillHolding>
	{
		public int Compare(SkillHolding a, SkillHolding b)
		{
			return 0;
		}
	}

	public class GearRarityComparator : IComparer<ItemHolding>
	{
		private int symbol;

		public GearRarityComparator(bool isHighToLow)
		{
		}

		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class GearLevelComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class GearPositionComparator : IComparer<ItemHolding>
	{
		private int symbol;

		public GearPositionComparator(bool bReverse)
		{
		}

		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class GearFragRarityComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class ItemSortComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class FragmentRarityComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class FragmentRarityUpComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class FragmentStarComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class FragmentStarUpComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class HeroFragRarityComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public class LuggageRarityComparator : IComparer<ItemHolding>
	{
		public int Compare(ItemHolding a, ItemHolding b)
		{
			return 0;
		}
	}

	public static RarityComparator Rarity;

	public static RarityUpComparator RarityUp;

	public static StarComparator Star;

	public static StarUpComparator StarUp;

	public static RankComparator Rank;

	public static RankUpComparator RankUp;

	public static HeroRarityComparator HeroRarity;

	public static HeroRarityComparator HeroRarityDown;

	public static HeroStarComparator HeroStar;

	public static HeroLevelComparator HeroLevel;

	public static HeroProfComparator HeroProf;

	public static SkillRarityComparator SkillRarity;

	public static SkillRarityComparator SkillRarityDown;

	public static SkillStarComparator SkillStar;

	public static SkillTypeComparator SkillType;

	public static GearRarityComparator GearRarity;

	public static GearRarityComparator GearRarityDown;

	public static GearLevelComparator GearLevel;

	public static GearPositionComparator GearPosition;

	public static GearPositionComparator GearPositionReverse;

	public static ItemSortComparator ItemSort;

	public static GearFragRarityComparator GearFragDefault;

	public static FragmentRarityComparator FragmentRarity;

	public static FragmentRarityUpComparator FragmentRarityUp;

	public static FragmentStarComparator FragmentStar;

	public static FragmentStarUpComparator FragmentStarUp;

	public static HeroFragRarityComparator HeroFragDefault;

	public static LuggageRarityComparator LuggageRarity;
}

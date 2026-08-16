using System;
using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public class HeroList : DataModelBase
	{
		private List<Hero> Heroes;

		private List<Hero> PurchCardHeroes;

		private Dictionary<int, List<Hero>> MyHeroesByCardID;

		public Action OnHeroChanged;

		private bool mIsChanged;

		private List<Hero> mHeroCard;

		private List<Hero> mHeroCardNotInFormaion;

		private List<Hero> mMaterilCard;

		private List<Hero> mFormaionCard;

		public List<Hero> MyHeroList => Heroes;

		public List<Hero> MyPruceCardHeroList => PurchCardHeroes;

		public int Count => Heroes != null ? Heroes.Count : 0;

		public int CardBagRestSpace => 0;

		public bool IsCardBagFull()
		{
			return false;
		}

		public void ClearHeroList()
		{
			Heroes?.Clear();
			PurchCardHeroes?.Clear();
			MyHeroesByCardID?.Clear();
		}

		private bool IsNewHero(Hero h)
		{
			return false;
		}

		private bool IsNewHero(HeroConfig hcfg)
		{
			return false;
		}

		public bool AddHero(Hero h, bool isMy, bool PurchCard = false)
		{
			if (h == null) return false;
			if (Heroes == null) Heroes = new List<Hero>();
			if (!Heroes.Contains(h))
			{
				Heroes.Add(h);
				return true;
			}
			return false;
		}

		public void MarkAllNewHeroOff()
		{
		}

		public bool CheckNewCard()
		{
			return false;
		}

		public void RemoveHero(Hero h)
		{
		}

		public List<Hero> GetHeroByID(int configID)
		{
			if (MyHeroesByCardID == null)
			{
				MyHeroesByCardID = new Dictionary<int, List<Hero>>();
			}
			if (!MyHeroesByCardID.ContainsKey(configID))
			{
				List<Hero> list = new List<Hero>();
				MyHeroesByCardID.Add(configID, list);
				return list;
			}
			return MyHeroesByCardID[configID];
		}

		public Hero FindByLocalID(int localID, bool purchCard = false)
		{
			List<Hero> list = purchCard ? PurchCardHeroes : Heroes;
			if (list != null)
			{
				return list.Find(h => h != null && h.LocalID == localID);
			}
			return null;
		}

		public int FindIndexByLocalID(int localID, bool PurchCard = false)
		{
			List<Hero> list = PurchCard ? PurchCardHeroes : Heroes;
			if (list != null)
			{
				return list.FindIndex(h => h != null && h.LocalID == localID);
			}
			return -1;
		}

		public void SortByRarity()
		{
		}

		public void Sort(IComparer<Hero> comparer)
		{
		}

		public int GetHeroCountByConfigID(int id)
		{
			return 0;
		}

		private void genateCardMatList()
		{
		}

		private void genateOnFormationList()
		{
		}

		private void sortCardList(List<Hero> listHero, Me.CardFilter sortType = Me.CardFilter.Default)
		{
		}

		private void filterCardRarity(List<Hero> src, ERarity[] forbitRatity)
		{
		}

		public List<Hero> FilterCardList(bool addHeroCard, bool addInFormation, bool addMaterilCard, ERarity[] forbitRatity, Me.CardFilter sortType = Me.CardFilter.Default, bool isMatFirst = false)
		{
			return null;
		}
	}
}

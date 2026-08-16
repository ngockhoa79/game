using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

public class DuplicateSettlement
{
	private class SettlementHeroComparer : IComparer<Hero>
	{
		public int Compare(Hero x, Hero y)
		{
			return 0;
		}
	}

	private class SettlementThingIdComparer : IComparer<ThingHolding>
	{
		public int Compare(ThingHolding x, ThingHolding y)
		{
			return 0;
		}
	}

	public int duplicateId;

	public bool win;

	public int stars;

	public int expGet;

	public float beforeExpPer;

	public float afterExpPer;

	public int beforeLv;

	public int afterLv;

	public int moneyGet;

	public int friendPoint;

	public Dictionary<int, List<ThingHolding>> lootsDic;

	public List<ThingHolding> allLoots;

	public DuplicateSettlement(bool _needSettlement, DuplicateSettlementProto _settlement, bool _win)
	{
	}

	public List<ThingHolding> GetLoots(int _fighterId)
	{
		return null;
	}

	public static void SortSettlementLoots(ref List<ThingHolding> _loots)
	{
	}

	public DuplicateSettlement()
	{
	}

	public void DestoryAll()
	{
	}
}

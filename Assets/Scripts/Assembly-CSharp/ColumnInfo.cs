using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

public class ColumnInfo
{
	public enum Relation
	{
		None = 0,
		Friend = 1,
		Stranger = 2
	}

	public Hero[] heroes;

	public List<int> LeaderIndexs;

	public string Name;

	public int ID;

	public Relation RelationShip;

	public bool IsNew;

	public int IndicatorIndex;

	private int arrayLocation;

	public ColumnInfo(int indicator, Hero[] h, List<int> indexs)
	{
	}

	public void SetPlayerInfo(string name, int playerID, Relation r, bool isNew)
	{
	}

	public static int CompareByRelationship(ColumnInfo infoA, ColumnInfo infoB)
	{
		return 0;
	}

	public CaptainStatus GetCaptainStatus(Hero h, out int index)
	{
		index = default(int);
		return default(CaptainStatus);
	}

	public Hero GetLeader()
	{
		return null;
	}

	public void ResolveArrayLocation(BattleFormationProto proto, int preset = -1)
	{
	}

	private int getColumnIndex(int position)
	{
		return 0;
	}

	public static Hero[] GetHeroes(BattleFormationProto proto, Player p)
	{
		return null;
	}

	public static Hero[] GetFerryHeroes(List<BattleFormationHeroProto> heroProtos)
	{
		return null;
	}

	public static Hero[] GetHeroes(List<BattleFormationHeroProto> heroProtos)
	{
		return null;
	}
}

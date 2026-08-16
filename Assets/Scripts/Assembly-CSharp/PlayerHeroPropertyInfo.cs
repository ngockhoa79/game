using Ice.ProjectCos.Protocol;

public class PlayerHeroPropertyInfo
{
	public int _Id;

	public HeroPropertyItem _Hp;

	public HeroPropertyItem _Attack;

	public HeroPropertyItem _Defense;

	public HeroPropertyItem _Spirit;

	public HeroPropertyItem _Speed;

	public HeroPropertyItem _Crit;

	public HeroPropertyItem _AntiCrit;

	public HeroPropertyItem _Miss;

	public HeroPropertyItem _AntiMiss;

	public HeroPropertyItem _Block;

	public HeroPropertyItem _AntiBlock;

	public int _Level;

	public int _Experience;

	public int _Potential;

	public PlayerHeroPropertyInfo(PlayerHeroPropertyInfoProto _info)
	{
	}

	public PlayerHeroPropertyInfo()
	{
	}
}

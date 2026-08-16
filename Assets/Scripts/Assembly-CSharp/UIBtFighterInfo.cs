public class UIBtFighterInfo
{
	private string name;

	private float hp;

	private float maxHP;

	public int FighterId;

	public int HeroId;

	public HeroRarityType HeroRarity;

	public CosProfession Profession;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float HP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaxHP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HPPercentage => 0f;

	public UIBtFighterInfo()
	{
	}

	public UIBtFighterInfo(string name, float hp, float maxHP)
	{
	}
}

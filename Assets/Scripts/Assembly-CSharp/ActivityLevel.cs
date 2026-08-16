using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

public class ActivityLevel
{
	private ActivityDuplicateTemplate mCfg;

	private List<ThingHolding> mDropThings;

	public int LevelID => 0;

	public int Difficult => 0;

	public int OpenLevel => 0;

	public int Index => 0;

	public int FormationID => 0;

	public string Desc => null;

	public List<ThingHolding> DropThings => null;

	public ActivityLevel(ActivityDuplicateTemplate temp)
	{
	}
}

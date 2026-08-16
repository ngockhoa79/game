using System.Collections.Generic;
using UnityEngine;

public class BattleHeroInfo
{
	public int FighterId;

	public int HeroId;

	public bool IsLeft;

	public bool IsPasser;

	public int Line;

	public int OriginLine;

	public BattleSmallLineType SmallLine;

	public int Column;

	public int Hp;

	public int Spirit;

	public List<int> SkillList;

	public List<int> PassiveSkills;

	public int Profession;

	public int Gender;

	public int ProfessionIndex;

	public GameObject HeroObject;

	public bool IsPassiveCast;

	public BattleHeroInfo(ReportHeroInfo _info)
	{
	}
}

using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class Editor_GlobalData
{
	public enum Editor_GenTargetType
	{
		None = 0,
		OneEnemy = 1,
		LineEnemy = 2,
		AllEnemy = 3,
		All = 4,
		MyColumn = 5,
		MySelfAddBuff = 6,
		MyColumnAddBuff = 7,
		EnemyColumnAddBuff = 8,
		FriendChangeLine = 9,
		SupportOneFriendAddBuff = 10,
		SupportOneEnemyAddBuff = 11
	}

	public static int Left_Hero_Id;

	public static int Right_Hero_Id;

	public static int Left_Support_Id;

	public static int Right_Support_Id;

	public static int Skill_Damage;

	public static bool isDodge;

	public static bool isBlock;

	public static bool isCrit;

	public static bool isZhuiji;

	public static HarmInfoProto.AgainstType kezhiType;

	private static SkillCtrller currentSkillCtrller;

	private static SkillType currentSkillType;

	private static int currentSkillId;

	private static int currentSourceId;

	private static int currentBuffId;

	private static bool currentIsLeft;

	public static void SetSkillInfo(SkillCtrller _skillCtrller, int _skillId, int _sourceFighterId, SkillType _skillType)
	{
	}

	private static void InitLeaderSkillList(int _skillId)
	{
	}

	private static HarmInfoProto GetHarmList(int _sourceFighterId, int _oppId)
	{
		return null;
	}

	private static List<HarmInfoProto> GetHarmList(int _sourceFighterId, List<int> _oppIdList)
	{
		return null;
	}

	private static void InitSkillWithList(Editor_GenTargetType _targetType)
	{
	}

	private static void GenAddBuffProtoData(BuffAddProto _buffProto)
	{
	}

	private static List<BuffAddProto> GenAddBuffProtoData(List<int> _targetList)
	{
		return null;
	}

	public static string GetSkillPrefabDir()
	{
		return null;
	}
}

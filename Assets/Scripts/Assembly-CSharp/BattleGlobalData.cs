using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class BattleGlobalData
{
	public enum BattleLayer
	{
		Background = 0,
		BackEffect = 1,
		Shadow = 2,
		Hero = 3,
		Foreground = 4
	}

	public static bool IsEdiorMode;

	public static bool IsStandaloneMode;

	public static bool MySideIsRight;

	public const string HEROSTATE_IDLE = "IdleState";

	public const int MIN_SKILL_ID_FROM_CONFIG = 100;

	public const int SKILLID_NORMAL_ATTACK1 = 1;

	public const int SKILLID_NORMAL_ATTACK2 = 2;

	public const int SKILLID_HEAVY_ATTACK = 3;

	public const int SKILLID_WANDER = 5;

	public const int SKILLID_TONEWLINE = 6;

	public const int SKILLID_REMAINADDHP = 7;

	public const int SKILLID_HERODIE = 8;

	public const int SKILLID_DUEL = 9;

	public const int SKILLID_ENTER_CARDIN = 20;

	public const int SKILLID_ENTER_WALKIN = 21;

	public const int SKILLID_ENTER_RUSHIN = 22;

	public const int SKILLID_ENTER_JUMPIN = 23;

	public const int SKILLID_ENTER_FALLDOWN = 24;

	public const int SKILLID_STORY_JUMPIN = 30;

	public const int SKILLID_STORY_JUMPOUT = 31;

	public const int SKILLID_SKY_ATTACK = 99;

	public static Vector3 BloodBarOffset;

	public static Vector3 WordsOffset;

	public static Vector3 ChatBubbuleOffset;

	public static Vector3 HarmNumOffset;

	public static string TextId_Dodge;

	public static string TextId_Crit;

	public static string TextId_Batter;

	public static string TextId_Block;

	public static string TextId_Kezhi;

	public static string TextId_Beike;

	public const string FsmChildInitEvent = "ToInitializeState";

	public const string FsmChildReadyEvent = "ToNextState";

	public static int SCENE_FIGHT_LEFT_EDGE;

	public static int SCENE_FIGHT_RIGHT_EDGE;

	public const int SCENE_FIGHT_TOP_EDGE = 320;

	public const int SCENE_FIGHT_BOTTOM_EDGE = -320;

	public static int SCENE_COLLIDE_EDGE;

	public const int STORY_START_FIGHTER_ID = 10000;

	public static int SCENE_DUEL_BOTTOM_LINE;

	public static int SCENE_DUEL_LINE_GAP;

	public static int MOVE_DISTANCE_FROM_LEFT_EDGE;

	public static int MOVE_DISTANCE_FROM_RIGHT_EDGE;

	public static int WANDER_SAFE_DISTANCE;

	public static int MOVESPEED_HERO_WALK;

	public static int MOVESPEED_HERO_RUN;

	public static int BATTLE_ROUND_TURN_N;

	public static int DUEL_BAR_REDUCE_SPEED;

	public static float Support_Help_Emote_Time;

	public const float GRAVITY = 2000f;

	public const float HERO_HIT_FLY_SPEED = 800f;

	public const int HERO_MONSTER_ID_SPLIT = 999999;

	public static int CameraCutIn_Y_OffSet;

	public static float FullCameraSize;

	public const int CUTIN_SKILL_MIN_RARITY = 4;

	public const float SMALL_SKILL_CUTIN_TIME = 2.5f;

	public const float HERO_HPBAR_SHOW_TIME = 2f;

	public const float TOPHEAD_IN_DELAY = 0.5f;

	public const float TOPHEAD_IN_GAP = 0.15f;

	public const float HP_DYING_PERCENT = 0.25f;

	public static int SKIP_VIP_LEVEL;

	public static int SKIP_TEAM_LEVEL;

	public static int SKIP_WAIT_TIME;

	public const int RESULT_VIP_W = 427;

	public const int RESULT_VIP_H = 640;

	public static int[] Z_Layers_Interval;

	public static int[] Line_Y;

	private const int ActiveTopY = 100;

	private const int ActiveBottomY = -300;

	public const int SMALL_LINE_Y_FIX = 30;

	public const int SMALL_LINE_Z_FIX = 5;

	public static int CurrentPlayerLevel;

	public static int currentSpeedMultiple;

	public static bool canSpeedup;

	public const int MaxUpSpeed = 2;

	public static int savedSpeed;

	private const float OneTimeSpeed = 1.35f;

	private const float TwiceTimeSpeed = 2f;

	private const string WdSkipString = "1133231";

	private static string currentWdS;

	public static float TopLineY => 0f;

	public static float BottomLineY => 0f;

	public static float AdaptorScale => 0f;

	public static int GetEnterBattleSkillId(EnterBattleType _type)
	{
		return 0;
	}

	public static void AdaptScreenEdge()
	{
	}

	public static float GetLeftMoveEdgeX()
	{
		return 0f;
	}

	public static float GetRightMoveEdgeX()
	{
		return 0f;
	}

	public static float GetBackEffectZ()
	{
		return 0f;
	}

	public static Vector3 GetPostion(BattleHeroInfo _info)
	{
		return default(Vector3);
	}

	public static Vector3 GetPostion(int _line, int _column, bool _isLeft, BattleSmallLineType _type)
	{
		return default(Vector3);
	}

	public static Vector3 GetBattleCenterPosition()
	{
		return default(Vector3);
	}

	public static Vector3 GetEnterBattlePostion(int _line, bool _isLeft, bool _randomOffset)
	{
		return default(Vector3);
	}

	public static Vector3 GetSupportStartPosition(int _line, bool _isLeft)
	{
		return default(Vector3);
	}

	public static Vector3 GetStoryHeroStartPosition(int _line, bool _isLeft, bool _front)
	{
		return default(Vector3);
	}

	public static float GetZ(float _y)
	{
		return 0f;
	}

	public static Vector3 GetDuelPosition(BattleHeroInfo _info)
	{
		return default(Vector3);
	}

	public static Vector3 GetSupportJumpInPosition(BattleHeroInfo _info)
	{
		return default(Vector3);
	}

	public static float GetYByLine(int _line, BattleSmallLineType _type)
	{
		return 0f;
	}

	public static float GetMoveSpeed(BattleMoveType _type)
	{
		return 0f;
	}

	public static BattleCollideWallType GetCollideWallType(string _heroState)
	{
		return default(BattleCollideWallType);
	}

	public static void SynchronousPlayerLevel()
	{
	}

	public static void AdjustSystemTime(AdjustTimeEvent _event)
	{
	}

	public static void ReadSavedSpeed()
	{
	}

	public static void SetSavedSpeed(int _speed)
	{
	}

	public static void SetToSavedSpeed()
	{
	}

	public static void HandleWdSkip(int _key)
	{
	}

	public static void FlipEffect(Transform _effect, bool _alreadyS = false)
	{
	}

	public static void InitPoolObject(GameObject _object, Transform _parent)
	{
	}

	public static void DestroyTweenScript(GameObject _object)
	{
	}

	public static float GetThrowY(float _vyStart, float _gravity, float _time)
	{
		return 0f;
	}

	public static int GetProfessionIndex(int _profession, int _gender)
	{
		return 0;
	}

	public static void DistinctIntList(List<int> _list)
	{
	}

	public static void PlayHitVoice(int _heroId, bool _isHeavyHit)
	{
	}

	public static string HashSetOutput(HashSet<int> _set)
	{
		return null;
	}

	public static void PlayModuleAnimation(GameObject _module)
	{
	}

	public static void PlayModuleAnimation(GameObject _module, float _arg)
	{
	}

	public static AbstractAnimator GetCriticalAnimator(GameObject _module)
	{
		return null;
	}

	public static void PlayIceAnimations(GameObject _module)
	{
	}

	public static IceAnimator GetCriticalIceAnimator(GameObject _module)
	{
		return null;
	}

	public static float GetIceAnimationsLength(GameObject _module)
	{
		return 0f;
	}

	public static void ResetIceAnimations(GameObject _module)
	{
	}

	public static void FinishIceAnimations(GameObject _module)
	{
	}

	public static void SetIceAnimationsDelay(GameObject _module, float _delay)
	{
	}

	public static void DestoryCosChildren(GameObject _object)
	{
	}

	public static void SystemDestoryChildren(GameObject _object)
	{
	}

	public static void CheckActivateShop()
	{
	}

	public static HeroGetHitResultType GetAttackHitResultFromHarm(HarmInfoProto _harmInfo)
	{
		return default(HeroGetHitResultType);
	}
}

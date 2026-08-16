using System.Collections.Generic;

public class CosConst
{
	public const string ServerVersion = "2.0.0";

	public static bool bEnableVIP_Function;

	public static float Timeout;

	public const float AllowedMaxHalfWidth = 568f;

	public const float AllowedMinHalfWidth = 480f;

	public const string PLAYERPREFS_BGM_ENABLE = "Audio_bBgmEnable";

	public const string PLAYERPREFS_SOUND_ENABLE = "Audio_bSoundEnable";

	public const string PLAYERPREFS_BGM_VOLUMN = "Audio_fBGMVolumn";

	public const string PLAYERPREFS_SOUND_VOLUMN = "Audio_fSoundVolumn";

	public const string PLAYERPREFS_KEY_USERNAME = "SavedUsername";

	public const string PLAYERPREFS_LAST_AREA_ID = "LastSelectedAreaId";

	public const string PLAYERPREFS_NOTIFY_GET_12_STAMINA = "Notify_Get12Stamina";

	public const string PLAYERPREFS_NOTIFY_GET_18_STAMINA = "Notify_Get18Stamina";

	public const string PLAYERPREFS_NOTIFY_FULL_STAMINA = "Notify_FullStamina";

	public const string PLAYERPREFS_NOTIFY_HONGBAO = "Notify_HongBao";

	public const string PLAYERPREFS_NOTIFY_CONVOY = "Notify_Convoy";

	public const string SCENENAME_LOGIN = "Stage1_Login";

	public const string SCENENAME_MAIN = "Stage2_Main";

	public const string SCENENAME_BATTLE = "Stage3_Battle";

	public const string SCENENAME_START = "Start";

	public const string SCENENAME_TEMP = "Stage0_Temp";

	public const string SCENENAME_GUIDANCE = "Stage4_Guidance";

	public const string INTERNAL_TEST_USERNAME_TITLE = "Coser";

	public const int BattleArrayLines = 3;

	public const int BattleArrayColumns = 3;

	public const int BattleArrayMachineColumns = 6;

	public const string RESTYPE_ITEM_ICON = "icon_items";

	public const string RESTYPE_SKILL_ICON = "icon_skills";

	public const string RESTYPE_EQUIPMENT_ICON = "icon_equipments";

	public const string RESTYPE_HERO_HEADICON = "icon_heroes";

	public const string RESTYPE_HERO_IMAGE = "cardimages";

	public const string RESTYPE_DIALOG_IMAGE = "card_images_dialog";

	public const string RESTYPE_BATTLE_UI = "uibattle";

	public const string RESTYPE_SOUND_STREAM = "sound_stream";

	public const string RESTYPE_SOUND_NOSTREAM = "sound_nostream";

	public const string RESTYPE_BGM_NOSTREAM = "bgm_no_stream";

	public const string RESTYPE_COMMON = "common";

	public const string RESTYPE_UICOMMON = "uicommon";

	public const string RESTYPE_GUILD = "uiguild";

	public const string SOUND_BOSS_WARNING = "sound_boss_warning";

	public const string SOUND_SUPPORT = "skill_attack_help";

	public const string SOUND_LEADER = "skill_buff";

	public const string SOUND_PASSIVE = "skill_buff2";

	public const string SOUND_NAME_DRAWCARD_NORMAL = "ui_gacha";

	public const string SOUND_NAME_DRAWCARD_RAIR = "ui_gacha_rate";

	public const string SOUND_NAME_LIANHUA = "ui_lianhua";

	public const string SOUND_NAME_ACTIVITY_BOSS = "ui_boss_appear";

	public const int RARITY_PURPLE = 4;

	public const int RARITY_GOLD = 5;

	public const int GEAR_MAX_LEVEL = 180;

	public const int BATTLE_SHOW_ID = 999999;

	public const int TOTAL_VIP_LEVEL = 17;

	public const int TutorialSmeltJourney = 20;

	public const int TutorialConvoy = 21;

	public const int TutorialLianhua = 22;

	public const int TutorialRefine = 23;

	public const int TutorialNurture = 24;

	public const int Tutorial25 = 25;

	public const int Tutorial26 = 26;

	public const int TypeWriterCharsSpeedPerSecond = 15;

	public const int TutorialSupportSkillId = 243302;

	public static HashSet<int> EmNpcIdSet;

	public const int Arena_Load_Delayed_Frames = 30;

	public const string PLAYERPREFS_OPACTIVITY_PREFIX = "FINISHTIME_OPACTIVITY_{0}_{1}";
}

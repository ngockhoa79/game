using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

public class ConfigTools
{
	private static HashSet<string> SlotSet;

	public static int GetSkillIdByPrefabName(string _skillName)
	{
		return 0;
	}

	public static string GetSkillPrefab(int _skillId)
	{
		return null;
	}

	public static bool IsSelfSkill(int _skillId)
	{
		return false;
	}

	public static SkillType GetSkillType(int _skillId)
	{
		return default(SkillType);
	}

	public static int GetSkillRarity(int _skillId)
	{
		return 0;
	}

	public static int GetSkillAddBuffId(int _skillId)
	{
		return 0;
	}

	public static int GetSkillHitTimes(int _skillId)
	{
		return 0;
	}

	public static string GetSkillDescription(int _skillId)
	{
		return null;
	}

	public static string GetSkillDescriptionWithName(int _skillId)
	{
		return null;
	}

	public static bool IsSupportSkill(int _skillId)
	{
		return false;
	}

	public static bool NeedCutinSkill(int _skillId)
	{
		return false;
	}

	public static string GetBuffPrefab(int _buffId, BuffStage _stage)
	{
		return null;
	}

	public static string GetBuffIcon(int _buffId)
	{
		return null;
	}

	public static bool IsLastBuff(int _buffId)
	{
		return false;
	}

	public static bool IsNeedAffactFsmBuff(int _buffId, BuffStage _stage)
	{
		return false;
	}

	public static bool IsHero(int _heroId)
	{
		return false;
	}

	public static int GetRealHeroId(int _heroId)
	{
		return 0;
	}

	public static HeroTemplateExt GetHeroInfo(int _heroId)
	{
		return null;
	}

	public static CosProfession GetHeroProfession(int _heroId)
	{
		return default(CosProfession);
	}

	public static HeroRarityType GetHeroRarity(int _heroId)
	{
		return default(HeroRarityType);
	}

	public static string GetHeroPrefab(int _heroId)
	{
		return null;
	}

	public static string GetHeadIcon(int _heroId)
	{
		return null;
	}

	public static string GetHeroImage(int _heroId)
	{
		return null;
	}

	public static string GetStoryTextureImageName(int _heroId)
	{
		return null;
	}

	public static int GetHeroIdFromStoryTextureName(string _name)
	{
		return 0;
	}

	public static string GetDialogText(int _id, BattleDialogTextType _type)
	{
		return null;
	}

	public static VoiceTemplate GetHeroVoiceTemp(int _heroId)
	{
		return null;
	}

	public static string GetDuplicateBg(int _duplicateId)
	{
		return null;
	}

	public static float GetProfessionKeyTime(int _professionIndex, string _keyName)
	{
		return 0f;
	}

	public static string GetText(string _id)
	{
		return null;
	}

	public static string GetEffectBundleType(string _effectName)
	{
		return null;
	}

	public static string GetHeroEffectBundleType(string _effectName)
	{
		return null;
	}

	public static string GetNormalAttackEffectBundle(CosProfession _profession)
	{
		return null;
	}

	public static List<HeroBoneEffectItem> GetHeroBoneEffects(int _heroId)
	{
		return null;
	}

	public static bool IsSlot(string _boneName)
	{
		return false;
	}

	public static List<BattleResourceItem> GetBattleFsmResources(string _prefabName)
	{
		return null;
	}

	public static float GetClientConfigData(string _name)
	{
		return 0f;
	}

	public static int GetFightCardNumberByLevel(int _level)
	{
		return 0;
	}

	public static string GetHeroProSpriteName(CosProfession _profession)
	{
		return null;
	}

	public static string GetHeroProSpriteName(EHeroProfession _profession)
	{
		return null;
	}
}

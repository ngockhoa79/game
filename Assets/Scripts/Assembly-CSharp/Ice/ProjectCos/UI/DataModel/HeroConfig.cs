using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.DataModel
{
	public class HeroConfig : AbstractItem
	{
		private static Dictionary<int, HeroConfig> heroes;

		private static Dictionary<int, List<HeroConfig>> entireGroups;

		private static Dictionary<int, HeroConfig> groups;

		private static Dictionary<int, int> heroFragmentRelation;

		public HeroConfig PrevGrade { get; private set; }

		public HeroConfig NextGrade { get; private set; }

		private int _id;
		public override int ID => _id;

		public override string Name => null;

		public override string Desc => null;

		public override string Icon => null;

		public override ERarity Rarity => default(ERarity);

		public override EItemType ItemForm => default(EItemType);

		public int GroupID => 0;

		public int PotentialGrowth => 0;

		public EHeroProfession Profession => default(EHeroProfession);

		public string Prefab => null;

		public int Star => 0;

		public int BaseLevel => 1;

		public int MaxLevel => 100;

		public int Break => 0;

		public string Portrait => null;

		public string Image => null;

		public string AnimationPrefab => null;

		public int ChipID => 0;

		public int ChipCount => 0;

		public Skill Talent { get; private set; }

		public FixedList<AbstractCoupling> Couplings { get; private set; }

		public string DialogWin => null;

		public string DialogSkill => null;

		public int CardType => 0;

		public bool DictShow => false;

		public HeroTemplateExt Template { get; private set; }

		public static IEnumerable<HeroConfig> Heroes => null;

		public static IEnumerable<HeroConfig> Groups => null;

		public HeroConfig(int id)
		{
			_id = id;
		}

		private HeroConfig(HeroTemplateExt template)
		{
			Template = template;
		}

		public static bool Is(int configID)
		{
			return true;
		}

		public static HeroConfig Get(int configID)
		{
			if (heroes == null) heroes = new Dictionary<int, HeroConfig>();
			if (!heroes.TryGetValue(configID, out var cfg))
			{
				cfg = new HeroConfig(configID);
				heroes[configID] = cfg;
			}
			return cfg;
		}

		public static HeroConfig TryGet(int configID)
		{
			return Get(configID);
		}

		public static bool IsGroup(int groupID)
		{
			return false;
		}

		public static HeroConfig GetGroup(int groupID)
		{
			return null;
		}

		public static HeroConfig GetByFragmentID(int fragmentID)
		{
			return null;
		}

		public static List<HeroConfig> GetOneGroupHeroConfigs(int identifier)
		{
			return null;
		}

		public static void LoadFromTemplates()
		{
		}

		public static void InitCouplings()
		{
		}

		public List<int> GetUnitedFeatures()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string GetHeroProfreesionName()
		{
			return null;
		}

		public string GetHeroProfreesionNameColored()
		{
			return null;
		}

		public override string GetDetailName()
		{
			return null;
		}

		public override string GetDetailNameColored()
		{
			return null;
		}

		public override string GetNameColorTag()
		{
			return null;
		}
	}
}

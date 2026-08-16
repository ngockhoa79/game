using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Gear : AbstractItem
	{
		public const int MinLevel = 1;

		public const int MaxLevel = 180;

		public const int SlotTypeCount = 4;

		private static Dictionary<int, Gear> gears;

		public override int ID => 0;

		public override string Name => null;

		public override string Desc => null;

		public string Action => null;

		public override string Icon => null;

		public EquipmentTemplate.MainProperty_ MainProperty => null;

		public override ERarity Rarity => default(ERarity);

		public override EItemType ItemForm => default(EItemType);

		public EGearSlot Slot => default(EGearSlot);

		public int ChipID => 0;

		public int ChipCount => 0;

		public UpgradableAbsValueBuff MajorBuf { get; private set; }

		public AbsValueBuff MinorBuf1 { get; private set; }

		public AbsValueBuff MinorBuf2 { get; private set; }

		public EquipmentTemplateExt Template { get; private set; }

		public static IEnumerable<Gear> Gears => null;

		public int GetMainPropertyCurrentValue(int currentLevel)
		{
			return 0;
		}

		private Gear(EquipmentTemplateExt template)
		{
		}

		public static bool Is(int configID)
		{
			return false;
		}

		public static Gear Get(int configID)
		{
			return null;
		}

		public static void LoadFromTemplates()
		{
		}

		public string GetMainPropertyString()
		{
			return null;
		}

		public string GetGearSlotName()
		{
			return null;
		}

		public string GetGearSlotNameColored()
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

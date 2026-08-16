using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class BaQiDataCenter
	{
		public static Hero SelectedHero;

		public static string[] attrList;

		public static bool CheckHeroItemEquip(Hero hero, int index)
		{
			return false;
		}

		public static bool CheckItemComprose(CardBaQiItem item, bool all = true)
		{
			return false;
		}

		public static bool CheckItemComprose(ItemChangeProto.ItemType type, int id, bool all = true)
		{
			return false;
		}

		public static void UpdateItemCount(CardBaQiItem item)
		{
		}

		public static List<CardBaQiItem> GetItemsByTemplate(GasTemplateExt temp)
		{
			return null;
		}

		public static List<CardBaQiItem> GetItemsByHero(int heroID, int level)
		{
			return null;
		}

		public static Dictionary<int, int> GetGassPropsKey(int heroID)
		{
			return null;
		}

		public static Dictionary<int, int> GetGassAllPropsByLevel(Hero hero, int level)
		{
			return null;
		}
	}
}

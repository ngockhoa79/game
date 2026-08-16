using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class NavigateManager
	{
		public const int GUILD_PARTY = 100;

		public const int GUILD_BUILD = 102;

		public static string[] ui_names;

		public static bool IsGuildInternalNavigator(int _type)
		{
			return false;
		}

		public static Navigator Parse(DropLevelClient dropLevel, object o = null)
		{
			return null;
		}

		private static IceUIIntent gotoPVE(int outChapterID, int duplicationID)
		{
			return null;
		}

		public static void GotoCardStrengthFromBattle()
		{
		}

		public static void GotoEquipmentStrengthFromBattle()
		{
		}

		public static void GotoSkillLevelupFromBattle()
		{
		}

		public static void GotoPVEVideo(int duplicationID)
		{
		}

		public static void MakePendingIntentFormNoUIScene(Intent i)
		{
		}

		private static void OnCallConvoyIntent()
		{
		}

		public static void ConvoyAction()
		{
		}
	}
}

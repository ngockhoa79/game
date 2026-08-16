using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class FriendshipLevelTemplateManager : ConfigSingle<FriendshipLevelTemplateManager, FriendshipLevelTemplate>
	{
		public FriendshipLevelTemplate Last => null;

		public FriendshipLevelTemplate First => null;

		public FriendshipLevelTemplate[] Items => null;

		public FriendshipLevelTemplate GetLevelTemplate(int level)
		{
			return null;
		}

		public int GetLevel(int totalFriendship)
		{
			return 0;
		}

		public void GetLevelExp(int totalFriendship, out int level, out int currentInnerExp, out int currentInnerMaxExp)
		{
			level = default(int);
			currentInnerExp = default(int);
			currentInnerMaxExp = default(int);
		}

		public FriendshipLevelTemplate GetItemByLevel(int lv)
		{
			return null;
		}
	}
}

using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class PlayerLevelTemplateManager : ConfigSingle<PlayerLevelTemplateManager, PlayerLevelTemplate>
	{
		public int MaxLevel => 0;

		public int GetLevelByTotalExp(int totalExp)
		{
			return 0;
		}

		public PlayerLevelTemplate GetPlayerLevelInfo(int level)
		{
			return null;
		}

		public int GetLvUpNeedExp(int level)
		{
			return 0;
		}

		public List<int> GetFunctionListByLevel(int level)
		{
			return null;
		}

		public int GetNewFunctionByLevel(int level)
		{
			return 0;
		}

		public int GetFunctionOpenLevel(int function)
		{
			return 0;
		}

		public bool FunctionOpened(int function)
		{
			return false;
		}

		public int GetEnergyBonus(int preLevel, int afterLevel)
		{
			return 0;
		}

		public int GetNextOpenFunction(int _currentLv)
		{
			return 0;
		}
	}
}

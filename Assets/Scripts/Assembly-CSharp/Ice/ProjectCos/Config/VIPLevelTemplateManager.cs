using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class VIPLevelTemplateManager : ConfigSingle<VIPLevelTemplateManager, VIPLevelTemplate>
	{
		public VIPLevelTemplate GetVIPLevelTemplate(int level)
		{
			return null;
		}

		public int GetVipFromTotal(int totaValue)
		{
			return 0;
		}

		public int GetArenaRedPackPickMaxCount(int vip)
		{
			return 0;
		}

		public int GetGuildRedPackPickMaxCount(int vip)
		{
			return 0;
		}

		public int GetRedPackSendMaxCount(int vip)
		{
			return 0;
		}

		public int GetBuyChallengePVPMaxCount(int vip)
		{
			return 0;
		}

		public int GetFreeSweepTimes(int vip)
		{
			return 0;
		}

		public int GetMakyouResetCDTimes(int vip)
		{
			return 0;
		}

		public VIPLevelTemplate GetMakyouResetCDTimesLargerThan(int vip)
		{
			return null;
		}

		public int GetMakyouBuyChangeOpponentTimes(int vip)
		{
			return 0;
		}

		public VIPLevelTemplate GetMakyouBuyChangeOpponentTimesLargerThan(int vip)
		{
			return null;
		}

		public int CheckMaxVipLevel()
		{
			return 0;
		}

		public VIPLevelTemplate[] GetItems()
		{
			return null;
		}
	}
}

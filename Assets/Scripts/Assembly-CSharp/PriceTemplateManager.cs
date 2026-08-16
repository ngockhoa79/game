using Ice.ProjectCos.Config;
using Ice.ProjectCos.ConfigGenerator.Template;

public class PriceTemplateManager : ConfigSingle<PriceTemplateManager, PriceTemplate>
{
	public TimesPriceInfo EnergyRefreshs { get; private set; }

	public TimesPriceInfo TrialRefreshStrangers { get; private set; }

	public TimesPriceInfo DuplicationPriceInfo { get; private set; }

	public TimesPriceInfo ShopRefreshInfo { get; private set; }

	public TimesPriceInfo ExtraArenaRedPacketInfo { get; private set; }

	public TimesPriceInfo ExtraGuildRedPacketInfo { get; private set; }

	public TimesPriceInfo BuyChallengePVPInfo { get; private set; }

	public TimesPriceInfo ActivityChallege { get; private set; }

	public TimesPriceInfo RobSkill { get; private set; }

	public TimesPriceInfo MakyouChangeOpponents { get; private set; }

	public TimesPriceInfo MakyouResetCD { get; private set; }

	public PriceTemplate GetPriceTemplate(int times)
	{
		return null;
	}

	public bool GetGoldExchangeByTime(int times, out int crystal, out int exchangedGold)
	{
		crystal = default(int);
		exchangedGold = default(int);
		return false;
	}
}

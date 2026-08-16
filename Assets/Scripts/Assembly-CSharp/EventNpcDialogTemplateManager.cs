using Ice.ProjectCos.Config;
using Ice.ProjectCos.ConfigGenerator.Template;

public class EventNpcDialogTemplateManager : ConfigSingle<EventNpcDialogTemplateManager, EventNpcDialogTemplate>
{
	public TimesPriceInfo EnergyRefreshs { get; private set; }

	public TimesPriceInfo TrialRefreshStrangers { get; private set; }

	public TimesPriceInfo DuplicationPriceInfo { get; private set; }

	public TimesPriceInfo ShopRefreshInfo { get; private set; }

	public TimesPriceInfo ExtraRedPacketInfo { get; private set; }

	public EventNpcDialogTemplate[] Items()
	{
		return null;
	}
}

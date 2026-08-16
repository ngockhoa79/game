using System;
using Ice.ProjectCos.UI.DataModel;

public class UIConvoyShipListItem : IceUIBase
{
	private const string RED = "[f00020]";

	private const string BLACK = "[000000]";

	private const string BLUE = "[194cab]";

	public UILabel PlayerName;

	public UILabel ShipName;

	public UISprite Bodyguard;

	public UILabel CoinValue;

	public UILabel GuildName;

	public UIEventListener LootButton;

	public UISprite LootButtonTextLoot;

	public UISprite LootButtonTextView;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public Action<EscortLobbyData> E_ShipSelected;

	private EscortLobbyData ShipData;

	public void SetData(EscortLobbyData ship)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	public void Update()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}

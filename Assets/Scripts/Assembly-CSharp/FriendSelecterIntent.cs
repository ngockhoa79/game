using System;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;

public class FriendSelecterIntent : IceUIIntent
{
	private const string IntentKey = "ArraySupporters";

	private const string ResCategory = "uiarrayeditor";

	public Action<Player> E_OnSelect;

	public Action E_OnClose;

	private ulong _exceptPlayerId;

	public FriendSelecterIntent(ulong exceptPlayerId)
	{
	}

	protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
	{
		return null;
	}

	protected override void SetPanelData()
	{
	}

	protected override void ClearPanelData()
	{
	}

	protected override void OnGetToForground()
	{
	}

	protected override void OnGetToBackgorund()
	{
	}

	private void handleBackClicked()
	{
	}

	private void handleOnHome()
	{
	}

	private void handleOnChosen(Player friend)
	{
	}

	private void Dehook()
	{
	}
}

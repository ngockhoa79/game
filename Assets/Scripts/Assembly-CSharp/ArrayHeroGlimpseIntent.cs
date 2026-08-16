using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;

public class ArrayHeroGlimpseIntent : IceUIIntent
{
	private const string IntentKey = "ArrayHeroGlimpse";

	private const string ResCategory = "uiarrayeditor";

	private Hero card;

	private bool canBeReplaced;

	public ArrayHeroGlimpseIntent(Hero card, bool canBeReplaced)
	{
	}

	protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
	{
		return null;
	}

	protected override void SetPanelData()
	{
	}

	private void handleOnReplaced(Hero card)
	{
	}

	private void handleOnClosed()
	{
	}

	protected override void ClearPanelData()
	{
	}
}

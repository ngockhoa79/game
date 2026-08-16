using HutongGames.PlayMaker;
using Ice.ProjectCos.UI.Intents;

[ActionCategory("ConditionalJudgment")]
public class ActivateEmbeddedShopNPC : FsmStateAction
{
	public bool Presentation;

	public override void OnEnter()
	{
	}

	private void inactive(Intent i)
	{
	}
}

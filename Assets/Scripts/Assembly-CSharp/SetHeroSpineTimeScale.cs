using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SetHeroSpineTimeScale : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat timeScale;

	public override void OnEnter()
	{
	}
}

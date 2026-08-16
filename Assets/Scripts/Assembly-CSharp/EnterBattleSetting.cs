using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class EnterBattleSetting : FsmStateAction
{
	public enum EnterBattleActionType
	{
		CreatePrefab = 0,
		CardIntoBattle = 1,
		CardTurnToHero = 2,
		DestroyPrefab = 3,
		GetWaitEnterTime = 4
	}

	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public EnterBattleActionType action;

	public FsmFloat exportTime;

	public const float GAP_TIME = 0.2f;

	public const int ENEMY_RARITY = 6;

	public const int BOSS_RARIY = 7;

	public override void OnEnter()
	{
	}
}

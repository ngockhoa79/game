using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class HeroWanderBeforeSkill : FsmStateAction
{
	[RequiredField]
	public FsmGameObject wanderHero;

	[RequiredField]
	public FsmGameObject wanderOppHero;

	private const float idleHoldTime = 0.2f;

	private const float totalWanderTime = 0.5f;

	private BattleHeroInfo heroInfo;

	private BattleHeroInfo oppInfo;

	private PlayMakerFSM heroFsm;

	private float wanderSpeed;

	private float timer;

	private bool isMove;

	private bool moveLeft;

	private float targetX;

	private float targetY;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SetWanderPolicy(bool _isLeft, float _heroX, float _oppX)
	{
	}
}

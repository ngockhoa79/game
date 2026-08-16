using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class CosGetHitCurve : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmBool enableX;

	[RequiredField]
	public FsmFloat XMax;

	[RequiredField]
	public FsmAnimationCurve curveX;

	[RequiredField]
	public FsmBool enableY;

	[RequiredField]
	public FsmFloat YMax;

	[RequiredField]
	public FsmAnimationCurve curveY;

	private float timer;

	private float downTimer;

	private float fallTimer;

	private float process;

	private float height;

	private float fallTargetY;

	private Space space;

	private int direction;

	private bool active;

	private bool reachWall;

	private bool heroRebound;

	private bool fallGroundOver;

	private Vector3 heroInitPosition;

	private PlayMakerFSM heroFsm;

	private BattleCollideWallType expectCollideType;

	private BattleCollideWallType currentCollideType;

	private const int COLLIDE_MIN_HEIGHT = 100;

	private const float FALL_DOWN_TIME = 0.4f;

	private const float FLY_COLLIDE_Y_START_SPEED = 500f;

	private const float FLY_COLLIDE_X_START_SPEED = 300f;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void UpdateHeroPosition(bool _final)
	{
	}

	private void UpdateHeroFly()
	{
	}

	private float CalculateHeroPosX(float _xOffset)
	{
		return 0f;
	}

	private void HandleCollidingWall()
	{
	}

	private void HandleFallGround()
	{
	}
}

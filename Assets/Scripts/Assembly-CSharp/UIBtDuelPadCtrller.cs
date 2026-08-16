using UnityEngine;

public class UIBtDuelPadCtrller : MonoBehaviour
{
	public delegate void DuelOverEvent(int _fighterId, bool _die);

	public UISprite SpriteBar;

	public UISprite HpBar;

	public UIBtFighterInfo FighterInfo;

	private bool duelingSpirit;

	private bool duelingHp;

	private float maxSpirit;

	private float maxHp;

	private float targetSpirit;

	private float targetHp;

	private float spirit;

	private float hp;

	public DuelOverEvent onDuelOver;

	public void StartDuel(int _spiritMax, int _spiritChange, int _hpMax, int _hpChange, DuelOverEvent _event)
	{
	}

	private void Update()
	{
	}

	private void StartDuelSprite()
	{
	}

	private void StartDuelHp()
	{
	}

	private void DuelOver(bool _die)
	{
	}
}

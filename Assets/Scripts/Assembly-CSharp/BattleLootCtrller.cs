using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class BattleLootCtrller : MonoBehaviour
{
	public GameObject Chest;

	public GameObject Item;

	public GameObject PickEffect;

	private bool dropping;

	private bool flying;

	private bool looting;

	private int direction;

	private int index;

	private float timer;

	private float lootTimer;

	private float dropXSpeed;

	private Vector3 initPos;

	private Vector3 dropTargetPos;

	private Vector3 flyInitPos;

	private Vector3 flyTargetPos;

	private const float flyingSpeed = 5f;

	private const float scaleSpeed = 1.5f;

	private const float lootTime = 2f;

	private void Update()
	{
	}

	private void OnClick()
	{
	}

	private void OpenChest()
	{
	}

	private void animatorPlayOver(AbstractAnimator _animator)
	{
	}

	public void InitItem(ThingHolding _itemHolding)
	{
	}

	public void StartDrop(GameObject _hero, int _index)
	{
	}

	public void DropUpdate(float _y)
	{
	}

	public void DropComplete()
	{
	}
}

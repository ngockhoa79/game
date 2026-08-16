using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleResultAddCounterCtrller : MonoBehaviour
{
	public UILabel NumberLabel;

	private int totalMoney;

	private int moneyNum;

	private bool moneyAdding;

	private float addPercent;

	private const float FILL_PRECENT_SPEED = 1f;

	public event Action OnFinish
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Update()
	{
	}

	private void Finish()
	{
	}

	public void HideLabel()
	{
	}

	public void PlayAddAnimator(int _money)
	{
	}

	public void ShowImmediately(int _number)
	{
	}
}

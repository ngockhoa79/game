using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleResultExpGroupCtrller : MonoBehaviour
{
	public GameObject ExpRoot;

	public UISprite Foreground;

	public UISprite ForeColorAdd;

	public UILabel LvLabel;

	public UILabel ExpLabel;

	public UILabel ExpCurrentLabel;

	public UILabel ExpMaxLabel;

	public GameObject FillOverAnim;

	private DuplicateSettlement settlement;

	private bool showOver;

	private bool filling;

	private int currentLv;

	private float currentPer;

	private int currentMax;

	private const float FILL_SPEED = 1f;

	public event Action LevelupCallBack
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

	private void SetExpBar(float _percent)
	{
	}

	private void SetCurrentLv(int _lv)
	{
	}

	public void SetExpGet(int _exp)
	{
	}

	public void SetBeforeExp(int _lv, float _percent)
	{
	}

	public void PlayExpAnimation(DuplicateSettlement _settlement)
	{
	}

	public void ShowImmediately(DuplicateSettlement _settlement)
	{
	}
}

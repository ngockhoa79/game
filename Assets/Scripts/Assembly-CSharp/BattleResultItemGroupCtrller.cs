using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleResultItemGroupCtrller : MonoBehaviour
{
	public GameObject itemRoot;

	public UISprite bg;

	private GameObject[] items;

	private int itemNum;

	private int currentIndex;

	private int lineNum;

	private bool showing;

	private bool waiting;

	private float timer;

	private DuplicateSettlement settlement;

	private const int LINE_ITEMS = 5;

	private const float SHOW_GAP = 0.15f;

	private const int X_GAP = 102;

	private const int Y_GAP = -97;

	private const float X_OFFSET = 96f;

	private const float Y_OFFSET1 = -65f;

	private const float Y_OFFSET2 = -55f;

	private const int LINE1_HEIGHT = 127;

	private const int LINE2_HEIGHT = 206;

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

	private void NewItemClose()
	{
	}

	private void Finish()
	{
	}

	public void SetLines(int _itemCount)
	{
	}

	public void ShowItems(DuplicateSettlement _settlement)
	{
	}

	public void ShowImmediately(DuplicateSettlement _settlement)
	{
	}

	private void SetLoots(DuplicateSettlement _settlement)
	{
	}
}

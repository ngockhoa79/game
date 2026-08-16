using System;
using System.Collections.Generic;
using UnityEngine;

public class UIScrollingBoardBase<C, T> : MonoBehaviour where C : Component where T : class
{
	public const string ResCategory = "uiguild";

	public float RollingInterval;

	private Timer timer;

	private int count;

	private int index;

	private List<T> records;

	private List<C> components;

	private UIGrid Grid;

	public string ResPrefab;

	public virtual void SetBoard(List<T> data)
	{
	}

	private void moment(List<T> data)
	{
	}

	public void InsertMoment(T insert)
	{
	}

	private void createMoment(List<T> three, bool reverse)
	{
	}

	public virtual C createOneLine(T proto, C input)
	{
		return null;
	}

	private void animating(Action callback)
	{
	}

	private void clearItems()
	{
	}
}

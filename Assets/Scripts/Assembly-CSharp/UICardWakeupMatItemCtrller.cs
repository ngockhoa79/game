using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardWakeupMatItemCtrller : MonoBehaviour
{
	public GameObject CheckMark;

	public UniIcon ItemIcon;

	public UILabel MatCounter;

	private Hero card;

	private bool matEnough;

	private AbstractItem item;

	private int myItemCount;

	private Action<bool> showAvatar;

	private Color EnoughColor;

	private Color NotEnoughColor;

	public bool MatEnough => false;

	public void Prepare(Action<bool> _showAvatar)
	{
	}

	public void ClearData()
	{
	}

	public void SetMainCard(Hero _card)
	{
	}

	public void SetItem(AbstractItem _item, int _needCount = 1)
	{
	}

	private void ShowSource(GameObject _object)
	{
	}

	private void OnSourceClose()
	{
	}
}

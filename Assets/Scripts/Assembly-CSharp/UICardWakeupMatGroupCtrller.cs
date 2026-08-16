using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardWakeupMatGroupCtrller : MonoBehaviour
{
	public UICardWakeupMatItemCtrller[] Items;

	private Hero card;

	public bool MatEnough => false;

	public void Prepare(Action<bool> _showAvatar)
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Hero _card)
	{
	}
}

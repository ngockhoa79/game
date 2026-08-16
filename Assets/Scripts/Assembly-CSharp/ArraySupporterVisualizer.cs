using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ArraySupporterVisualizer : IceUIReusableList<Player>.IVisualizer
{
	public ArraySupporters.EntrancePoint entrance;

	public event Action<Player> OnChosen
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

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, Player data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	private void handleOnChosen(Player player)
	{
	}
}

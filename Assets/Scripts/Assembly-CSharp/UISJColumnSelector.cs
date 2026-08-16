using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UISJColumnSelector : MonoBehaviour
{
	private static int ColumnAmount;

	private string[] RelationSprites;

	public GameObject Occupied;

	public GameObject Empty;

	public UISprite RelationShip;

	public GameObject New;

	public GameObject OnBoard;

	public UILabel Name;

	public UILabel Power;

	public UIAeSlot[] Slots;

	public UIEventListener BodyClicker;

	public Action<int> OnSelected;

	public UILeaderSkillIndicator SkillIndicator;

	private ColumnInfo ci;

	private Hero[] column
	{
		set
		{
		}
	}

	private bool isNew
	{
		set
		{
		}
	}

	private bool isEmpty
	{
		set
		{
		}
	}

	private bool isOnboard
	{
		set
		{
		}
	}

	public void SetDetails(int src, ColumnInfo ci, bool isempty, bool isonboard)
	{
	}
}

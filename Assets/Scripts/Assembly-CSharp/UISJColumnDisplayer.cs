using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UISJColumnDisplayer : MonoBehaviour
{
	public int Index;

	private static int ColumnAmount;

	private string[] RelationSprites;

	public GameObject Occupied;

	public GameObject Vacancy;

	public UIAeSlot[] Slots;

	public UILabel Name;

	public UISprite RelationShip;

	public UILabel IndexLabel;

	public UIEventListener btnClicker;

	public UILeaderSkillIndicator SkillIndicator;

	private ColumnInfo ci;

	private Hero[] column
	{
		set
		{
		}
	}

	public void SetDetails(ColumnInfo ci)
	{
	}

	private void handleVacancyClicked(GameObject btn)
	{
	}

	public void handleSwitcherClicked(GameObject btn)
	{
	}

	public void SetIndex(int index)
	{
	}

	private void Awake()
	{
	}

	private bool hasFront(int r, int c)
	{
		return false;
	}
}

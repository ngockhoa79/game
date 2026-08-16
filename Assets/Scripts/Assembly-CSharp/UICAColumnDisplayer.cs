using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICAColumnDisplayer : MonoBehaviour
{
	private static int ColumnAmount;

	private string[] RelationSprites;

	public int Index;

	public GameObject Occupied;

	public UIAeSlot[] Slots;

	public UILabel Name;

	public UISprite RelationShip;

	public UILeaderSkillIndicator SkillIndicator;

	public bool[] HasSupportSkill;

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
}

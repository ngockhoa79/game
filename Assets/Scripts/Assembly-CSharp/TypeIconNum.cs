using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class TypeIconNum : MonoBehaviour
{
	public enum IconType
	{
		Gold = 0,
		Diamond = 1,
		Stamina = 2,
		FriendShip = 3,
		Reputation = 4
	}

	public UISprite spIcon;

	public UILabel lbNum;

	private IconType mType;

	private void Start()
	{
	}

	public void SetIcon(IconType type, int num)
	{
	}

	public void SetIcon(PropertyHolding p)
	{
	}
}

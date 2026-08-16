using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class CardDropFromItem : MonoBehaviour
{
	public UISprite spIcon;

	public UISprite spTypeNormal;

	public UISprite spTypeHero;

	public GameObject BGNormal;

	public GameObject BGDrak;

	public UILabel lbChataNum;

	public UILabel lbChataDesc;

	public UILabel lbProgressLeft;

	public UILabel lbProgressRight;

	public UIEventListener eventRoot;

	private PVELevel mData;

	private bool mCanGo;

	public Action<PVELevel> OnGotoLevel;

	public void SetData(PVELevel data)
	{
	}

	private void handleItemClicked(GameObject btn)
	{
	}
}

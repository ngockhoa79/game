using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardWakeupHeadCtrller : MonoBehaviour
{
	public GameObject SpineObject;

	public GameObject EmptyCard;

	public GameObject SelectedCard;

	public UI4CardDisplayer CardDisplayer;

	private Hero card;

	private bool isLeft;

	public void Prepare(bool _isLeft)
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Hero _card)
	{
	}

	public void ShowAvatar(bool _show)
	{
	}

	public void SelectHero(GameObject _object)
	{
	}

	private void OnSelectMainCard(List<ItemHolding> _holdings)
	{
	}

	private void OnSelectMainCardCancel()
	{
	}

	private void RefreshUI()
	{
	}

	private void ClearSpineObject()
	{
	}

	private void LoadUIHero(int configID, GameObject parent, bool isLeft)
	{
	}
}

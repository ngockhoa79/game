using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiHeadCtrller : IceUIBase
{
	public GameObject EmptyCard;

	public GameObject SelectedCard;

	public UI4CardDisplayer CardDisplayer;

	private Hero card;

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoClearData()
	{
	}

	public void SetData(Hero _card)
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
}

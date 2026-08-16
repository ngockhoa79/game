using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardLevelupMatGroupCtrller : MonoBehaviour
{
	public class CardLvupMatComparer : IComparer<Hero>
	{
		public int Compare(Hero x, Hero y)
		{
			return 0;
		}
	}

	public UIStrengthenMatBtnCtrller[] MatButtons;

	public UIEventListener AutoAddBtn;

	public UILabel MatCounter;

	private Hero card;

	private List<Hero> Cards;

	private HashSet<int> CardsOnField;

	private const int MAT_MAX = 10;

	private int matExp;

	private Action onMatChange;

	public int TotalExp => 0;

	public int MatCount => 0;

	public List<Hero> MatsList => null;

	public bool HasHighRarityCard => false;

	private bool IsIllegalState => false;

	private int FullExpGap => 0;

	public void Prepare(Action _onMatChange)
	{
	}

	public void ClearData()
	{
	}

	public void SetMainCard(Hero _card)
	{
	}

	public void CheckMatChange()
	{
	}

	public void ClearMaterials()
	{
	}

	private void InitMaterialList()
	{
	}

	private void RefreshData()
	{
	}

	private void OnMatClicked(GameObject _object)
	{
	}

	private void SaveCurrentMat()
	{
	}

	private void OnMatsSelected(List<ItemHolding> heroes)
	{
	}

	private void OnMatSelectCancel()
	{
	}

	private void OnAutoAddClicked(GameObject obj)
	{
	}

	private void CalculateExp()
	{
	}

	private int GetHeroEatExp(Hero _hero)
	{
		return 0;
	}

	private bool AlreadyContainsMat(int _localId)
	{
		return false;
	}

	private void AutoSelectMaterials()
	{
	}
}

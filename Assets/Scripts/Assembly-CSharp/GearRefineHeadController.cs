using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineHeadController : MonoBehaviour
{
	public GameObject EmptyGroup;

	public GameObject SelectGroup;

	public UI4GearDisplayer GearDisplayer;

	public UILabel GearRefineCurrentLevel;

	public UILabel GearRefineMaxLevel;

	public Action E_OnHeaderClick;

	private GearHolding gear;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(GearHolding _gear)
	{
	}

	public void SelectGear(GameObject _object)
	{
	}

	private void OnSelectGear(List<ItemHolding> _holdings)
	{
	}

	private void OnSelectCancel()
	{
	}
}

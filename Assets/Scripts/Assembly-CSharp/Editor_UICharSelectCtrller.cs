using System.Collections.Generic;
using UnityEngine;

public class Editor_UICharSelectCtrller : MonoBehaviour
{
	public UIPopupList charList;

	private bool changeEventSet;

	private List<string> heroPrefabs;

	private string selectHero;

	private bool isLeft => false;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnSelectionChange(string _name)
	{
	}

	public string GetSelectHeroPrefab()
	{
		return null;
	}
}

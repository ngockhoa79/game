using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardNurtureItem : IceUIBase
{
	public UILabel CardName;

	public UILabel CardLevelNumber;

	public UICmStarDisplayer CardStarGroup;

	public UIAeCardDisplayer CardPortrait;

	[SerializeField]
	private GameObject OnField;

	[SerializeField]
	private GameObject Locked;

	[SerializeField]
	private UIEventListener SelectButton;

	public Action<Hero> OnSelect;

	private Hero card;

	public void SetData(Hero card)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnSelectClicked(GameObject obj)
	{
	}
}

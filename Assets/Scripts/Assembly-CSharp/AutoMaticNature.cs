using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class AutoMaticNature : IceUIBase
{
	[SerializeField]
	private UIToggle[] SelectionsNatureType;

	[SerializeField]
	private UIToggle[] SelectionsNatureTimes;

	[SerializeField]
	private UIToggle[] SelectionsNatureLimit;

	[SerializeField]
	private UIToggle[] SelectionsNatureLimit1;

	[SerializeField]
	private UIToggle[] SelectionsNatureLimit2;

	[SerializeField]
	private UIEventListener NatureButton;

	[SerializeField]
	private UIEventListener CLoseButton;

	[SerializeField]
	private UILabel XianDou;

	[SerializeField]
	private UILabel Diamond;

	private const int XiandouID = 40000014;

	private int xiandouCounter;

	private int crystalCounter;

	private const int GroupIdType = 2018;

	private const int GroupIDTimes = 2019;

	[SerializeField]
	private GameObject Group1;

	[SerializeField]
	private GameObject Groun2;

	[SerializeField]
	private GameObject DiamondObj;

	public Hero Card;

	public Action<object> Response;

	private int index;

	private void Start()
	{
	}

	private void PrepareToggle()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void RefreshXiandou()
	{
	}

	private void OnCloseClick(GameObject obj)
	{
	}

	private void OnNatureClick(GameObject obj)
	{
	}

	private void NatureBack(object message)
	{
	}

	private void OnSelectTypeChange()
	{
	}

	private void OnSelectTimesChange()
	{
	}

	private void RefreshResume()
	{
	}
}

using System;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardNurtureEnsure : IceUIBase
{
	[SerializeField]
	private UIAeCardDisplayer Protrait;

	[SerializeField]
	private UILabel CardName;

	[SerializeField]
	private UILabel CardLevel;

	[SerializeField]
	private UILabel PotentialPoint;

	[SerializeField]
	private UILabel Medicine;

	[SerializeField]
	private UICmStarDisplayer Stars;

	[SerializeField]
	private UILabel[] PerValue;

	[SerializeField]
	private UILabel[] CurValue;

	[SerializeField]
	private UILabel[] Sign;

	[SerializeField]
	private UILabel[] Delta;

	[SerializeField]
	private UIEventListener AbandonButton;

	[SerializeField]
	private UIEventListener EnsureButton;

	private string ColorRed;

	private string ColorGreen;

	private string ColorYellow;

	private int MedicineID;

	private int medicineNumber;

	private int potential;

	public Action OnAbandon;

	public Action OnEnsure;

	public void SetData(Hero card, HeroNurtureInfoProto info)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnStatusDelta(UICardNurtureDataCtrller.CardStatus type, int value)
	{
	}

	private void OnAbandonClicked(GameObject obj)
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}
}

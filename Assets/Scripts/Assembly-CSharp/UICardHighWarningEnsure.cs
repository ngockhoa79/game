using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardHighWarningEnsure : IceUIBase
{
	[SerializeField]
	private UILabel LblTips;

	[SerializeField]
	private UILabel LblCardName;

	[SerializeField]
	private UILabel LblEnsure;

	[SerializeField]
	private UILabel LblLevel;

	[SerializeField]
	private UILabel LblPopup;

	[SerializeField]
	private UIAeCardDisplayer CardPortrait;

	[SerializeField]
	private UICmStarDisplayer CardStars;

	[SerializeField]
	private IceUIToggleButton PopupCheckBox;

	public UIEventListener EnsureButton;

	public UIEventListener CancelButton;

	public Action<Hero> OnEnsure;

	public Action OnCancel;

	public Action<bool> OnSelectPopup;

	private string colorYellow;

	private Hero hero;

	public void SetData(Hero hero)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void OnCancelClicked(GameObject obj)
	{
	}

	private void OnSelectClicked(GameObject obj)
	{
	}
}

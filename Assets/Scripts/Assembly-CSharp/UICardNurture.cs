using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardNurture : IceUIBase
{
	[SerializeField]
	private UILabel XiandouLabel;

	[SerializeField]
	private UILabel CrystalLabel;

	[SerializeField]
	private UICardNurtureHeadCtrller HeadCtrller;

	[SerializeField]
	private UICardNurtureDataCtrller DataCtrller;

	[SerializeField]
	private UICardNurtureSelectionsCtrller SelectionsCtrller;

	[SerializeField]
	private UICardNurtureTabMaskCtrller TabMaskCtrller;

	[SerializeField]
	private UIEventListener NurtureBtn;

	[SerializeField]
	private UIEventListener OneNurtureBtn;

	[SerializeField]
	private UIEventListener ResultConfirmBtn;

	[SerializeField]
	private UIEventListener ResultCancelBtn;

	[SerializeField]
	private UIEventListener RestoreBtn;

	[SerializeField]
	private UILabel lbRestorePrize;

	[SerializeField]
	private IceAnimatorTotalCommander PickCardAnim;

	[SerializeField]
	private IceAnimatorTotalCommander NurtureClickAnim;

	[SerializeField]
	private IceAnimatorTotalCommander NurtureConfirmAnim;

	[SerializeField]
	private IceAnimatorTotalCommander NurtureCancelAnim;

	[SerializeField]
	private GameObject AutoMaticNatureUI;

	private Hero card;

	private int xiandouCounter;

	private int crystalCounter;

	private bool isShowingResult;

	private const int XiandouID = 40000014;

	public UIEventListener ButtonHelp;

	protected override void DoPrepare()
	{
	}

	private void OnHelpButtonClicked(GameObject go)
	{
	}

	public void ResetData(Hero _card)
	{
	}

	public void SetData(Hero _card, bool _needRefreshAll = true)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	private void Update()
	{
	}

	private void RefreshXiandou()
	{
	}

	private void OnNurtureClicked(GameObject _object)
	{
	}

	private void OnOneNurtureClicked(GameObject obj)
	{
	}

	private void OnNurtureRespose(object response)
	{
	}

	private void OnResultConfirmClicked(GameObject _object)
	{
	}

	private void OnResultCancelClicked(GameObject _object)
	{
	}

	private void HideResult()
	{
	}

	private void OnCommitResponse(object response)
	{
	}

	private void OnNurtureMessage(object msg, int msgId)
	{
	}

	private void SetRestoreBtn(Hero _card)
	{
	}

	private void ConfirmRestoreNurture(int localid)
	{
	}

	private int CalculateRestoreXiandou(Hero _card)
	{
		return 0;
	}

	private int CalculateAllQianLi(Hero _card)
	{
		return 0;
	}
}

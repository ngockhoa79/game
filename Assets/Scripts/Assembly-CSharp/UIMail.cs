using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMail : IceUIBase, IceUIReusableList<MailItemInfo>.IVisualizer
{
	public IceUIBtnGroup TabButton;

	private int mSelectedIndex;

	public UIEventListener eventOutBack;

	public UIEventListener eventOutMain;

	public UIEventListener eventReceiveAllMail;

	public UILabel lbNotice;

	public UILabel lbTitleMailCount;

	public IceAnimatorTotalCommander animatorTotalCommanderNoMail;

	public GameObject MailListPart;

	public UIMailListAnimator MailList;

	public MailCategory Catalog;

	private int maxMail;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoDispose()
	{
	}

	public void OnChangeTab(int oldIndex, int newIndex)
	{
	}

	public void SetTitle()
	{
	}

	public void SetList()
	{
	}

	public void ShowMailList()
	{
	}

	public void HideMailList()
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, MailItemInfo data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void RequestAllMail()
	{
	}

	public void OnGetMailItemReward(MailItemInfo mInfo, ItemMail uiItem)
	{
	}

	public void OnViewMailItemBattle(MailItemInfo mInfo, ItemMail uiItem)
	{
	}

	public void OnViewMailItemDetail(MailItemInfo mInfo, ItemMail uiItem)
	{
	}

	public void MarkMailRead(MailItemInfo mInfo, ItemMail uiItem)
	{
	}

	public void ReveiveAllMail()
	{
	}
}

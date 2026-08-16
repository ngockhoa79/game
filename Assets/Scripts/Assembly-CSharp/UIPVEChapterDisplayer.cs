using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVEChapterDisplayer : IceUIBase
{
	public enum PanelType
	{
		None = 0,
		Init = 1,
		Selected = 2,
		NotSelected = 3,
		Deactivate = 4
	}

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public UILabel lbCountLeft;

	public UILabel lbStatimaCost;

	public UILabel lbName;

	public UILabel lbLevel;

	public UISprite spStar1;

	public UISprite spStar2;

	public UISprite spStar3;

	public UISprite spStar1Dark;

	public UISprite spStar2Dark;

	public UISprite spStar3Dark;

	public UIEventListener btnEnter;

	public UIEventListener btnSaoDang;

	public UISprite spStatima;

	public UISprite TxtLevel;

	public UIEventListener eventDragObject;

	public BoxCollider bcDragObject;

	public GameObject rootBgSelect;

	public GameObject rootBgDeactive;

	public IceAnimatorTotalCommander initAni;

	public IceAnimatorTotalCommander notSelectAni;

	public IceAnimatorTotalCommander SelectAni;

	public UIPVEChapterEnemyHead enemyHead;

	private PVELevel Holding;

	public Action<GameObject, PVELevel> E_OnEnter;

	public Action<GameObject, PVELevel> E_OnSaoDang;

	public Action<GameObject, PVELevel> E_OnClicked;

	public Action<GameObject, PVELevel, bool> E_OnPressed;

	public Action<GameObject, PVELevel, Vector2> E_OnDragged;

	private int ProgressType;

	private int duplicationId;

	private GameObject popupObj;

	private UICardAmountMaxStatus popupUI;

	private Vector3 LevelNormalCollider;

	private Vector3 LevelSelectedCollider;

	private PanelType currentPanel;

	public int DuplicationId => 0;

	public PVELevel HoldingData => null;

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void SetData(PVELevel content, int progressType)
	{
	}

	private void OnEnterClicked(GameObject obj)
	{
	}

	private void PopupCardAmountMaxWarning()
	{
	}

	private void ClosePopup()
	{
	}

	private void ClosePopupUI()
	{
	}

	private void OnSaoDangClicked(GameObject obj)
	{
	}

	private void OnEventDragObjPress(GameObject go, bool state)
	{
	}

	private void OnEventDragObjDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnEventDragObjClick(GameObject go)
	{
	}

	public void SetSelection(bool _bSelected)
	{
	}

	protected void SetStar(int star)
	{
	}

	protected void SetPanel(PanelType panel)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}

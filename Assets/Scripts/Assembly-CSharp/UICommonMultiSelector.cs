using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICommonMultiSelector : IceUIBase
{
	public enum ESelectorType
	{
		Skill = 0,
		Gear = 1,
		Card = 2
	}

	public delegate IEnumerable<ItemHolding> H_GetListFilter();

	public delegate GameObject H_CreateWidget(Transform widgetHolder);

	public class CommonMultiSelectorVisualizer : IceUIReusableList<ItemHoldingGroup>.IVisualizer
	{
		public readonly UICommonMultiSelector Owner;

		public CommonMultiSelectorVisualizer(UICommonMultiSelector owner)
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

		public void SetData(GameObject widget, ItemHoldingGroup item)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[HideInInspector]
	public int MaxSelectionCount;

	[HideInInspector]
	public bool AutoConfirmMode;

	[HideInInspector]
	public bool bIncludeUnload;

	public UICommonMultiSelectorList List;

	public UIEventListener btnHomePage;

	public UIEventListener btnReturn;

	public UIEventListener btnConfirm;

	public UIEventListener btnCancelAll;

	public UISprite spTab;

	public UISprite spCustomLabel;

	public IceAnimatorTotalCommander empty_anim;

	public Action E_OnHomePage;

	public Action E_OnReturn;

	public Action<List<ItemHolding>> E_OnConfirm;

	public H_GetListFilter E_OnGetListFilter;

	public H_CreateWidget E_OnCreateWidget;

	public H_CreateWidget E_OnCreateSperator;

	public Action<GameObject, ItemHoldingGroup, UICommonItem.EState, UICommonItem.EState> E_OnSetData;

	public Action<GameObject> E_OnClearData;

	public Action<GameObject, UICommonItem.EState, UICommonItem.EState> E_OnWidgetStateChanged;

	public Action<ItemHolding, bool> E_OnSelect;

	public Action E_OnUnload;

	private List<ItemHolding> _inSelectionList;

	public void ClickItem(ItemHolding itemHolding)
	{
	}

	public void RefreshData()
	{
	}

	public void SetSelectorType(ESelectorType stype)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoDispose()
	{
	}

	internal void GroupSetData(GameObject widget, ItemHoldingGroup item)
	{
	}

	private UICommonItem.EState GetItemHoldingState(ItemHolding itemHolding)
	{
		return default(UICommonItem.EState);
	}

	private void OnCancelAll()
	{
	}

	private bool _check_is_in_selection(ItemHolding itemholding)
	{
		return false;
	}

	public void SelectionAdd(ItemHolding itemholding)
	{
	}

	private bool SelectionRemove(ItemHolding itemholding)
	{
		return false;
	}
}

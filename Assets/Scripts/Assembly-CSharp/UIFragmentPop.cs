using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.GameOperations;
using UnityEngine;

public class UIFragmentPop : IceUIBase
{
	private enum EState
	{
		None = 0,
		Robbery = 1,
		Notify = 2
	}

	public class FragmentPopVisualizer : IceUIReusableList<FragmentPopupContent>.IVisualizer
	{
		public readonly UIFragmentPop Owner;

		public FragmentPopVisualizer(UIFragmentPop owner)
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

		public void SetData(GameObject widget, FragmentPopupContent data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class FragmentPopNotificationVisualizer : IceUIReusableList<FragmentPopupNotificationContent>.IVisualizer
	{
		public readonly UIFragmentPop Owner;

		public FragmentPopNotificationVisualizer(UIFragmentPop owner)
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

		public void SetData(GameObject widget, FragmentPopupNotificationContent data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public IceUIBtnGroup tabs;

	public UIFragmentPopList ListRobbery;

	public UIFragmentPopNotificationList ListNotification;

	public UIEventListener btnClose1;

	public UIEventListener btnClose2;

	public Action<UIFragmentPopList> E_OnClickTabRobbery;

	public Action<UIFragmentPopNotificationList> E_OnClickTabNotification;

	public Action<FragmentPopupContent> E_OnFanJi;

	public Action<FragmentPopupContent> E_OnHelp;

	public Action<FragmentPopupContent> E_OnReplay;

	public Action<FragmentPopupNotificationContent> E_OnSupport;

	public Action E_OnClose;

	private EState _curState;

	private RobberyInfoReqOp.EType type;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	public void SetTab(RobberyInfoReqOp.EType type)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void OnTabChanged(int index, int index2)
	{
	}

	public void OnCounter(FragmentPopupContent data)
	{
	}

	public void OnHelper(FragmentPopupContent data)
	{
	}

	public void OnReplay(FragmentPopupContent data)
	{
	}

	public void OnSupport(FragmentPopupNotificationContent data)
	{
	}

	private void SetState(EState tarState, Action callback = null)
	{
	}

	private void change_to_state(EState tarState, Action callback)
	{
	}

	public void ForceRefreshTabRobbery(List<FragmentPopupContent> list)
	{
	}
}

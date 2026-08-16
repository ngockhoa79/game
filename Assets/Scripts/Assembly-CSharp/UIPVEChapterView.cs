using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVEChapterView : IceUIBase
{
	public class ChapterVisualizer : IceUIReusableList<PVELevel>.IVisualizer
	{
		public readonly UIPVEChapterView Owner;

		public ChapterVisualizer(UIPVEChapterView owner)
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

		public void SetData(GameObject widget, PVELevel item)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_internal_refresh_chapter_list__003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPVEChapterView _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_internal_refresh_chapter_list__003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CresetScrollView_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPVEChapterView _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CresetScrollView_003Ed__48(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public UIPVEChapterLilst ChapterList;

	public UIPVEChapterInfo ChapterInfo;

	public UILabel lbEnergy;

	public UIEventListener btnAddEnergy;

	public Action<GameObject, PVELevel> E_OnEnter;

	public Action<GameObject, PVELevel> E_OnSaoDang;

	public Action<GameObject, PVELevel> E_OnSelected;

	public Action<GameObject, PVELevel, bool> E_OnPressed;

	public Action<GameObject, PVELevel, Vector2> E_OnDrag;

	public Action E_OnAddEnergy;

	[HideInInspector]
	public int ProgressType;

	[NonSerialized]
	private int _chapterId;

	[NonSerialized]
	public bool bActivate;

	private UIPVEChapterDisplayer currentDisplayer;

	private bool IsSelectEnd;

	private readonly int rangeY;

	private float scrollTarget;

	private readonly float strength;

	private readonly float correctedValue;

	private UIScrollView uiScrollView;

	private GameObject popupObj;

	private GameObject guidePopupObj;

	private UIGainItemPop popupUI;

	private UIPVEBonusPopup popup2UI;

	private UIPVEChapterGuide guidePopup;

	private UIPopupCardBagFull cardBagFullPopup;

	private int duplicationID;

	private bool energyRefreshFlag;

	public string CurrentTabButton;

	private int counter;

	public int ChapterId => 0;

	public string NewTabButton { get; private set; }

	public PVEProgress CurrentProgress => null;

	public void SetChapterId(UIPVEChapterContainer container, int chapterId, int selectedIndex)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	[IteratorStateMachine(typeof(_003C_internal_refresh_chapter_list__003Ed__41))]
	private IEnumerator _internal_refresh_chapter_list_()
	{
		return null;
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void OnGuideEntered()
	{
	}

	private void OnGuideClosed()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CresetScrollView_003Ed__48))]
	private IEnumerator resetScrollView()
	{
		return null;
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void ResetTabFucntion()
	{
	}

	private void OnChapterBonusClicked(bool flag)
	{
	}

	public void OnDuplicationSelected(GameObject go, PVELevel data)
	{
	}

	public void OnSetButton(PVELevel data)
	{
	}

	private void SetEnterStatus()
	{
	}

	private void OnCallTaskRewardPick(GameObject obj)
	{
	}

	private void OnPopupEntered()
	{
	}

	private void OnPopupClosed()
	{
	}

	private void OnMenuEntered()
	{
	}

	private void OnCloseCallback()
	{
	}
}

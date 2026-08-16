using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIDrawCardActivity : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003CDoShowCard_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawCardActivity _003C_003E4__this;

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
		public _003CDoShowCard_003Ed__49(int _003C_003E1__state)
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

	public UILabel lbCountGem;

	public UICostDisplayer CostDraw;

	public UICostDisplayer CostDraw10;

	public UILabel lbMyIndex;

	public UILabel lbMyScore;

	public UILabel lbFreeCount;

	public GameObject NoRank;

	public UpdateTimerUTC CDTimerDiamond;

	[SerializeField]
	private UpdateTimerUTC EndTimer;

	public UIEventListener eventDraw;

	public UIEventListener eventDraw10;

	public UIEventListener eventHome;

	public UIEventListener eventHelp;

	public UIEventListener eventCharge;

	public UILabel lbDrawPupleCountDonw;

	public UILabel lbDrawHint;

	public GameObject FreeCount;

	public GameObject Free;

	public UIGrid gdPlayerList;

	public UIGrid gdAwardList;

	public GameObject goItemPlayerList;

	public GameObject goItemAward;

	public CardBig Card1;

	public CardBig Card2;

	private CardBig mCardIn;

	private CardBig mCardOut;

	public GameObject BGMask;

	private int DrawCardItemId;

	private bool mShowing;

	private List<HeroConfig> mShowList;

	private int mShowIndex;

	private void Start()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void RequestInfo()
	{
	}

	public void RequestDrawSingle()
	{
	}

	public void RequestDraw10()
	{
	}

	private void requestActivityDraw(bool isSingel)
	{
	}

	public void ShowMask(bool isShow)
	{
	}

	private int RefreshDrawItem()
	{
		return 0;
	}

	public void setTitle(int value = 0)
	{
	}

	private void beginCDDiamond()
	{
	}

	public void addPlayerList()
	{
	}

	public void addAwardList()
	{
	}

	private void showCard()
	{
	}

	[IteratorStateMachine(typeof(_003CDoShowCard_003Ed__49))]
	private IEnumerator DoShowCard()
	{
		return null;
	}

	public void ShowDrawCountDown(bool isShow = true)
	{
	}

	private void openHelpDialong()
	{
	}
}
